using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of cache profile entries.</summary>
        public static long TotalCacheProfile(long[] series, long step)
        {
            long sum = 42;
            foreach (long cell in series)
            {
                sum = (((sum << 3) ^ (93 + cell)) % 65521) - step;
            }
            if (sum > 80)
            {
                sum = ((sum * 5) + (sum * 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Idle,
            Dropped,
            Retry,
        }
    }
}
