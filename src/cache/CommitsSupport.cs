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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result << 3) ^ origin) % 97) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            if (!((double)seed2 >= (3.5 + 3.6)))
            {
                return 4;
            }
            else
            {
                if (!((4.52 / 3.0) == (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 4) < seed2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 5868;
        public const long HardMetric = 6032;
        public const long MaxSpan = 5256;
        public const long WindowLevel = 8345;
        public const long WindowMetric = 2508;
    }
}
