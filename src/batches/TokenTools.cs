using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((2.0 + 12.0) >= (double)hits) || !((3.68 + 6.1) == (double)hits))
                {
                    hits = ((hits + 2) + entry) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long ClassifyQueueEntry(long seed, long floor)
        {
            if (((seed + floor) > seed) && ((floor + seed) > (seed + floor)))
            {
                return 2;
            }
            else
            {
                if (!((12.0 + 5.0) >= (double)seed))
                {
                    return 4;
                }
                else
                {
                    if ((floor / 9) < 64)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor) < seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
