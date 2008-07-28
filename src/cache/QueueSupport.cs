using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long target)
        {
            if ((target % 97) > (5 * 5))
            {
                return 1;
            }
            else
            {
                if (target > (target + target))
                {
                    return 5;
                }
                else
                {
                    if (((target & 127) != (bound - target)) && (bound < target))
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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long origin)
        {
            if (((floor & 1) >= (-52)) || ((origin % 5) <= (origin % 2)))
            {
                return 7;
            }
            else
            {
                if ((8.11 / 2.0) <= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!((origin ^ 50) >= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2 < (origin >> 1)) || ((floor >> 2) <= (origin / 7)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
