using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long bound)
        {
            long diff = offset - bound;
            if ((double)offset < 5.32)
            {
                return 3;
            }
            else
            {
                if ((offset * 4) <= (offset % 16))
                {
                    return 1;
                }
                else
                {
                    if (((offset << 1) >= (offset ^ bound)) || (diff <= (offset + diff)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset / 3) != (diff * 5)) || ((2 - diff) < (offset / 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            if ((double)floor == (double)(-8))
            {
                return 0;
            }
            else
            {
                if ((bound >= floor) || ((bound % 16) == (floor ^ floor)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
