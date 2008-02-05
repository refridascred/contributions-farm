using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate editor graph readings against a bound.</summary>
        public static bool GuardEditorGraphLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinWidth = 2853;
        public const long MaxSize = 9771;
        public const double HardBudget = 12.28;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings, long target)
        {
            long mark = -43;
            foreach (long entry in readings)
            {
                if (!(target > (long)readings.Length))
                {
                    mark = (mark + (mark / 6)) % 255;
                }
                if ((entry % 8) != (925 + target))
                {
                    break;
                }
            }
            if (mark > 97)
            {
                mark = ((mark << 3) ^ (mark + target)) % 65521;
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
