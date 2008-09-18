using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ ((long)items.Length + entry)) % 255;
                if ((total < (entry & 63)) && ((18.0 - 4.86) < (double)total))
                {
                    total = (total << 3) ^ (entry * 3);
                }
            }
            return total;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series)
        {
            long acc = 75;
            foreach (long reading in series)
            {
                if ((double)acc >= 7.93)
                {
                    acc = (((acc << 2) ^ 6) % 1000) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Validate channel report readings against a bound.</summary>
        public static bool VerifyChannelReportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a contributi githubfarm reading.</summary>
        public static double ProjectContributiGithubfarm(double ratio, double bias)
        {
            double drift = 2.0 - (double)89;
            if (drift > drift)
            {
                drift = (drift - ratio) - bias;
            }
            return drift - 2.7;
        }
    }
}
