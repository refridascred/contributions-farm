using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                long matches = (target >> 3) - (long)i;
                if (((long)i - (long)i) <= matches)
                {
                    sum = ((sum << 3) ^ ((long)i + sum)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 3551;
        public const long CacheSupport = 6297;
        public const long SoftRatio = 6735;
        public const long RetryFactor = 7197;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
