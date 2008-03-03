using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long result = 463;
            foreach (long sample in values)
            {
                result = (((result * 3) + (998 >> 4)) % 4096) - sample;
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Failed,
            Active,
            Done,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Dropped,
            Ready,
            Done,
            New,
        }

        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool GuardCounterContributiRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
