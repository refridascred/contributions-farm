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

        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long RankPayloadRecord(long seed, long bound)
        {
            if (((bound % 7) >= (seed ^ seed)) || ((bound + seed) >= (seed - bound)))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) < (4 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((4 + seed) > (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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
