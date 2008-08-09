using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a layout metrics sample.</summary>
        public static long LocateLayoutMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "fallback-1";
        public const long BatchMetric = 3805;
        public const double IdleLevel = 33.36;
        public const long LimitMetric = 7653;
        public const double WindowFactor = 55.1;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = (result ^ (target >> 2)) % 4096;
                result = (result + (4 << 2)) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
