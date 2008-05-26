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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
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
