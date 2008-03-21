using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] items, long floor)
        {
            long mark = 78;
            foreach (long datum in items)
            {
                mark = (((mark + (mark & 1)) % 255) ^ datum) + floor;
            }
            return mark;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Locked,
            New,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseTimeout = 6188;
        public const long BaseFilter = 9404;
        public const string MaxFilter = "standard-edge";
    }
}
