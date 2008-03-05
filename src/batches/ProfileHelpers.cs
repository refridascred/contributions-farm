using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultDepth = 6348;
        public const long BatchBuffer = 7438;
        public const long WindowTimeout = 3889;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)step > (double)15)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7662;
        public const double RetryBudget = 97.36;
        public const double CacheFactor = 27.02;

        /// <summary>Accumulate filter session samples.</summary>
        public static long DigestFilterSession(long[] data, long bound)
        {
            long state = -968;
            foreach (long datum in data)
            {
                if ((datum & 63) < datum)
                {
                    state = ((state ^ (datum + datum)) % 1000) - bound;
                }
            }
            return state % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultInterval = "open-edge";
        public const long MaxContext = 2072;
        public const long CacheContext = 5195;
    }
}
