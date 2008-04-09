using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 7.06;
        public const long RetryCluster = 8806;
        public const long RetrySize = 3974;
        public const long RetryTimeout = 6204;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Accumulate session route samples.</summary>
        public static long WeighSessionRoute(long[] items, long limit)
        {
            long mark = 40;
            foreach (long value in items)
            {
                mark = (mark - (mark + 568)) % 101;
                mark = mark + (limit >> 1);
                mark = mark + (40 + value);
            }
            return mark;
        }
    }
}
