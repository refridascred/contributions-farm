using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (0 < seen)
                {
                    seen = ((seen + 3) ^ item) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Paused,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Active,
            Locked,
            Closed,
            Failed,
        }
    }
}
