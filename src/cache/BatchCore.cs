using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seed / 6) <= 1)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6265;
        public const long CacheSupport = 278;
        public const long IdleRatio = 2373;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Ready,
            Active,
            Locked,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Stale,
            Ready,
            Active,
        }
    }
}
