using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cluster metric reading by value.</summary>
        public static long LocateClusterMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session batches input into a small class.</summary>
        public static long RankSessionBatches(long floor, long limit)
        {
            if ((floor + floor) > limit)
            {
                return 7;
            }
            else
            {
                if ((690 / 9) >= (floor % 24))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (floor >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit == (14.0 + 4.0)) && ((double)limit > (1.15 * 6.91)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
