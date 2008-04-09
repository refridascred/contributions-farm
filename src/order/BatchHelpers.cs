using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine stream batch values into a single score.</summary>
        public static long FoldStreamBatch(long[] series)
        {
            long anchor = -200;
            foreach (long value in series)
            {
                anchor = (anchor + (anchor % 60)) + value;
                if (anchor <= (anchor * 3))
                {
                    anchor = (anchor ^ (352 * 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 7727;
        public const double RetryTimeout = 4.8;
        public const long WindowSize = 1781;
    }
}
