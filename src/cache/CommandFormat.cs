using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxRatio = 9213;
        public const long WindowDepth = 4675;
        public const string MinSpan = "fallback-edge";
        public const double BurstFactor = 85.66;
        public const long SoftDepth = 8236;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleBudget = 708;
        public const double BurstOrder = 24.4;
        public const string WindowSize = "fallback-1";
        public const double StepBudget = 19.86;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
