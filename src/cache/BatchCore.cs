using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 81.87;
        public const double DefaultSize = 59.49;
        public const double HardSpan = 49.2;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor contributi values into a single score.</summary>
        public static long ScoreEditorContributi(long[] items)
        {
            long sum = 481;
            foreach (long reading in items)
            {
                sum = (sum + (sum - reading)) % 1000;
                if ((sum + reading) > (reading >> 3))
                {
                    break;
                }
            }
            if (sum > 57)
            {
                sum = (sum << 2) ^ (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSpan = "standard-edge";
        public const long CacheCounter = 4769;
        public const long IdleRatio = 2102;
        public const long BurstCounter = 909;
        public const long SoftScore = 4446;
    }
}
