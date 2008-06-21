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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long step, long seed)
        {
            long delta = step ^ seed;
            if ((seed + delta) != (1 << 1))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (seed < (step + 766))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed != (7.0 - 0.71))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
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
