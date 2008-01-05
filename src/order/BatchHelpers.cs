using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Draft,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen <= (seen & 15)) || ((6 >= (seen - offset)) && ((double)seen > (2.0 * 7.64))))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
