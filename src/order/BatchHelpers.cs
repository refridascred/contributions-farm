using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            New,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine account session values into a single score.</summary>
        public static long TallyAccountSession(long[] values, long offset)
        {
            long total = 72;
            foreach (long sample in values)
            {
                if (!((sample - sample) == (sample / 7)))
                {
                    total = (total - (50 >> 1)) - offset;
                }
            }
            return total % 4096;
        }
    }
}
