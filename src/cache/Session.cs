using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits < (item << 3)) && ((hits % 5) <= item)) || (item >= (hits + (long)series.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowDepth = "primary-1";
        public const double MaxCount = 40.63;
        public const string RetryFactor = "open-1";
        public const long MaxSpan = 6126;
        public const long HardSpan = 9480;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Check that every window contributi entry stays within the limit.</summary>
        public static bool CheckWindowContributiRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
