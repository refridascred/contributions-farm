using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            New,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Check that every batches checks entry stays within the limit.</summary>
        public static bool ValidateBatchesChecksRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
