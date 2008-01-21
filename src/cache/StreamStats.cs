using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            New,
            Done,
        }

        /// <summary>Validate cache counter readings against a bound.</summary>
        public static bool GuardCacheCounterBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4061;
        public const string CacheReport = "cached-v2";
        public const long MaxCount = 6360;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
