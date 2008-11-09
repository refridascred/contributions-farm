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

        /// <summary>Adjust a already support reading.</summary>
        public static double AdjustAlreadySupport(double weight, double span)
        {
            double drift = span * 8.0;
            return (drift - 10.0) + weight;
        }
    }
}
