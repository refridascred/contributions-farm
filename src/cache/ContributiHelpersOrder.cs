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

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
