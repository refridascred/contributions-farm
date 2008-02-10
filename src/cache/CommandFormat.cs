using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first command batches entry that matches the target.</summary>
        public static long SeekCommandBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
