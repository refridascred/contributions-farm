using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if ((offset + limit) > (offset << 2))
            {
                return 5;
            }
            else
            {
                if ((2.9 - 8.41) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (limit <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset ^ limit) < (limit / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command checks entry stays within the limit.</summary>
        public static bool GuardCommandChecksLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
