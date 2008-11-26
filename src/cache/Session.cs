using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Done,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long seed)
        {
            if (bound < seed)
            {
                return 4;
            }
            else
            {
                if ((553 - bound) > (67 + bound))
                {
                    return 2;
                }
                else
                {
                    if ((4 - seed) == ((-566) % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
