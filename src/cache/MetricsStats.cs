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

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Ready,
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long mix = 895;
            foreach (long datum in series)
            {
                if ((mix + limit) != (259 + limit))
                {
                    mix = (mix - (datum + mix)) % 4096;
                    mix = (mix ^ datum) % 255;
                    break;
                }
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix - (limit % 60)) - (long)i;
                }
                mix = (mix + datum) % 97;
            }
            if (mix < 265)
            {
                mix = ((mix * 3) + (limit ^ mix)) % 65521;
            }
            return mix;
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
