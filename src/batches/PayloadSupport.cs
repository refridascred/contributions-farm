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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((double)hits <= (4.9 + 14.0)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
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
