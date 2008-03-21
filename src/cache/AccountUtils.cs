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

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
