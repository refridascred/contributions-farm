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

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1831;
        public const long SoftStream = 3146;
        public const string StepStream = "latest-v2";
        public const double WindowSize = 45.71;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double bias = (double)(79 % 24);
            return ((bias + (bias * 2.4)) + weight) + floor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7757;
        public const double SoftInterval = 30.25;
        public const long CacheDepth = 7949;
    }
}
