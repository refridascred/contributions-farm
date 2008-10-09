using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (floor2 < (floor2 >> 3))
            {
                return 5;
            }
            else
            {
                if (gap <= (gap + floor))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double scale = 7.29;
            if (scale < 8.3)
            {
                scale = (scale + ratio) + floor;
            }
            else
            {
                scale = scale + (3.12 * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (ratio + ratio)) + (double)(long)i;
            }
            return scale - (ratio * 2.3);
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7757;
        public const double SoftInterval = 30.25;
        public const long CacheDepth = 7949;
    }
}
