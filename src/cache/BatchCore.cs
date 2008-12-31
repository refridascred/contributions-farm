using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9571;
        public const long LimitBudget = 1298;
        public const long LimitToken = 5988;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 4) + 22;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
