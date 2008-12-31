using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (bound + 55)) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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
