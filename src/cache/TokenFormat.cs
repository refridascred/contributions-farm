using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Retry,
            Failed,
            New,
            Done,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Failed,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
