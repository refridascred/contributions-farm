using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long target)
        {
            if (target > ((-69) >> 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.4 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long offset2)
        {
            long cur = offset + offset2;
            if (!((offset2 ^ offset2) > offset))
            {
                return 2;
            }
            else
            {
                if ((double)cur >= 4.8)
                {
                    return 1;
                }
                else
                {
                    if (cur >= (offset / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 ^ cur) < (75 - offset2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches << 2) == (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
