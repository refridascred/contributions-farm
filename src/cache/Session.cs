using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Retry,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 6092;
        public const long LimitWindow = 7290;
        public const string RetryWindow = "fallback";
        public const double LimitWidth = 60.57;
        public const long BurstWindow = 3330;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Stale,
            Idle,
            New,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
