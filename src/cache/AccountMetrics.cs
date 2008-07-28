using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 54.14;
        public const string HardQueue = "open";
        public const long LimitQueue = 8673;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 297;
        public const long LimitRatio = 6752;
        public const double BatchScore = 24.21;

        /// <summary>Find the first support format entry that matches the target.</summary>
        public static long SeekSupportFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryInterval = 85.39;
        public const string SoftFarm = "cached-1";
        public const double StepFarm = 32.88;
        public const double MinFarm = 21.83;
    }
}
