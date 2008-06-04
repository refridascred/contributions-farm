using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstWidth = 53.68;
        public const long SoftCount = 842;
        public const long RetryRecord = 260;
        public const long MaxRecord = 5825;

        /// <summary>Match up counter contributi samples.</summary>
        public static long MatchCounterContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double mean = span;
            if (mean >= (ratio + span))
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (span + span)) + (double)(long)i;
            }
            return mean - (mean + span);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long bound)
        {
            long total = 436;
            foreach (long sample in data)
            {
                total = (total ^ (total << 1)) % 255;
                if ((bound >> 2) >= (27 + sample))
                {
                    total = (total * 2) + bound;
                }
            }
            return total;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
