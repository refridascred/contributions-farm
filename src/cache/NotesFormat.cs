using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits < (1.31 / 4.0))
                {
                    hits = ((hits + 3) + item) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long SortEntryCommand(long seed, long seed2)
        {
            if (((double)seed2 > 4.52) && ((seed - 1) >= (910 + seed2)))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) > seed) && ((3 >> 1) == (seed ^ seed2)))
                {
                    return 3;
                }
                else
                {
                    if (seed2 < (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (6 > seed2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Failed,
            Stale,
        }
    }
}
