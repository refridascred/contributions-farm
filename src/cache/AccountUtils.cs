using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 2556;
        public const long WindowFactor = 157;
        public const string LimitBatches = "standard";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - (long)values.Length) >= (item & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - (offset >> 4)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
