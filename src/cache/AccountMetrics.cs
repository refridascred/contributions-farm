using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of account queue readings.</summary>
        public static long PairAccountQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 415;
        public const long SoftContext = 1214;
        public const long CacheContext = 3231;
        public const string BaseInterval = "open-edge";
        public const long StepContext = 6703;

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 7677;
        public const double BurstSize = 95.47;
        public const long MaxEditor = 7707;
        public const long MinEditor = 399;
        public const long BurstRatio = 7836;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double gain = span;
            return gain - scale;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Failed,
            Draft,
            Idle,
        }
    }
}
