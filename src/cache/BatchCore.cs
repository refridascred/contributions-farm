using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long target)
        {
            if ((0.8 + 15.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long state = 9;
            foreach (long entry in series)
            {
                if ((double)state < 0.77)
                {
                    state = (state * 4) + (entry - state);
                }
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Synced,
            New,
        }
    }
}
