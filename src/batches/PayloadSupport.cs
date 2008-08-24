using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long RankClusterFarm(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (((20 - offset2) < (64 % 12)) && (693 >= (offset + floor)))
            {
                return 5;
            }
            else
            {
                if (((floor / 7) == (offset2 & 3)) && ((9.04 + 5.8) > (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (offset % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 7) < floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum <= count) || ((limit >> 3) <= count))
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

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Failed,
            Stale,
            Dropped,
        }
    }
}
