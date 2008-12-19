using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Locked,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool VerifyAccountTokenLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            New,
            Queued,
        }
    }
}
