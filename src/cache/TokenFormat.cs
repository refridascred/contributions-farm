using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (13.0 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long seed)
        {
            if ((seed + offset) <= offset)
            {
                return 0;
            }
            else
            {
                if ((seed * 2) == (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset << 1) != (offset + seed)) && ((seed + offset) < (offset >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.62 / 9.0) > (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
