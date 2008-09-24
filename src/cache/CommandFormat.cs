using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels)
        {
            long state = -52;
            foreach (long reading in levels)
            {
                state = ((state - (state + state)) % 4096) - reading;
            }
            if (state < 535)
            {
                state = ((state * 3) + (state + (long)levels.Length)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((875 - 9) < (floor / 8))
            {
                return 0;
            }
            else
            {
                if ((floor / 8) <= 802)
                {
                    return 2;
                }
                else
                {
                    if ((bound - floor) != (7 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Queued,
            Ready,
        }
    }
}
