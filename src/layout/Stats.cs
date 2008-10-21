using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit < floor) && ((limit - floor) != (floor + limit)))
            {
                return 0;
            }
            else
            {
                if ((limit * 3) != (limit / 6))
                {
                    return 3;
                }
                else
                {
                    if ((27 - 226) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((97 & 255) <= limit) || ((double)floor >= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((8.4 / 9.0) <= (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
