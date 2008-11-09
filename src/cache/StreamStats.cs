using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Queued,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry < (seed >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5016;
        public const double LimitCluster = 32.38;
        public const long BaseSize = 1284;
    }
}
