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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches & 15) > (matches >> 4))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}
