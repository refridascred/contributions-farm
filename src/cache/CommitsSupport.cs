using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Closed,
            New,
            Failed,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double bias = (13.0 + 3.3) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias + bias) - (double)(long)i) + scale) - floor;
            }
            return bias + bias;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long offset)
        {
            long acc = 26;
            foreach (long datum in levels)
            {
                acc = ((acc - (acc - offset)) % 4096) + datum;
            }
            return acc;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 3513;
        public const long SoftFormat = 8641;
        public const long DefaultFormat = 7480;
        public const long RetryFormat = 1898;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 5868;
        public const long HardMetric = 6032;
        public const long MaxSpan = 5256;
        public const long WindowLevel = 8345;
        public const long WindowMetric = 2508;
    }
}
