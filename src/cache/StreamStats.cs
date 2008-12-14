using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema token entries.</summary>
        public static long TotalSchemaToken(long[] levels)
        {
            long state = 55;
            foreach (long entry in levels)
            {
                if (!(5.6 <= (double)entry))
                {
                    state = ((state * 3) + (entry + state)) % 97;
                }
                if (((long)levels.Length + entry) > (entry >> 4))
                {
                    state = state - (state + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (989 >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchLevel = "legacy-v2";
        public const long BaseSize = 6658;
        public const long RetryTimeout = 6976;
        public const string BurstEntry = "alpha-edge";
        public const long LimitEntry = 5548;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Closed,
            Queued,
            Paused,
        }
    }
}
