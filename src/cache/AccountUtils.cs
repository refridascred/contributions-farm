using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Synced,
            Ready,
        }
    }
}
