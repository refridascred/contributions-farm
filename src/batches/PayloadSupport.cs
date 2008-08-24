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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
