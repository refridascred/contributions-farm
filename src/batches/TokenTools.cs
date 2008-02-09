using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Synced,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((2.2 / 3.0) > (double)origin)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long seed, long limit)
        {
            if ((seed % 3) <= (3 & 63))
            {
                return 7;
            }
            else
            {
                if (((double)limit > (double)seed) || (seed < limit))
                {
                    return 1;
                }
                else
                {
                    if (19 >= (limit + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
