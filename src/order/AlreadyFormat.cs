using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result + bound) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the cache counter entries that pass the check.</summary>
        public static long AuditCacheCounterGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (7 > (value >> 1))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double weight = (double)830;
            if (weight <= bias)
            {
                weight = (weight + (double)32) + floor;
            }
            return weight - (0.4 / 2.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "primary-edge";
        public const long IdleMetrics = 8724;
        public const string LimitMetrics = "standard-1";
        public const long WindowMetrics = 7094;

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long floor)
        {
            long state = 900;
            foreach (long cell in data)
            {
                if (((state % 8) == ((long)data.Length - floor)) && ((41 * 3) <= (cell + 5)))
                {
                    state = (state - cell) % 101;
                }
                state = state ^ cell;
            }
            return state;
        }
    }
}
