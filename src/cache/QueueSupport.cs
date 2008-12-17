using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.53 + 6.5) <= (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            New,
            Paused,
            Idle,
        }
    }
}
