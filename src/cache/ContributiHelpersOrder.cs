using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (((cur ^ cur) != (bound >> 5)) || ((541 << 1) != (floor % 3)))
            {
                return 6;
            }
            else
            {
                if (((floor - bound) > (floor - cur)) && ((floor / 8) >= (cur / 2)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + floor) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long step)
        {
            if (origin > (9 % 7))
            {
                return 2;
            }
            else
            {
                if ((origin >> 2) >= (6 - origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a notes entry reading by value.</summary>
        public static long FindNotesEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
