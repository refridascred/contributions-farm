using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long floor2)
        {
            long lane = floor ^ floor2;
            if (((double)lane > (double)floor2) && ((floor + floor2) < lane))
            {
                return 8;
            }
            else
            {
                if ((16.0 / 2.0) > (double)floor2)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long SeriesToolsContext(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ ((long)i - (long)i)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate buffer order samples.</summary>
        public static long TallyBufferOrder(long[] items, long limit)
        {
            long state = 326;
            foreach (long sample in items)
            {
                if ((sample - sample) == (limit * 4))
                {
                    state = state + sample;
                }
                if ((sample % 97) != (sample + 93))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits - entry) <= (entry + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
