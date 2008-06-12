using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (target <= (125 & 63))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
