using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (2.3 >= (double)reading)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long offset)
        {
            if ((957 & 7) < (seed >> 5))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (double)4)
                {
                    return 2;
                }
                else
                {
                    if (((offset * 5) >= (offset % 24)) && ((offset + seed) <= (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.26 >= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - value) == (63 / 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
