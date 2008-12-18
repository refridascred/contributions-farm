using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long limit, long floor)
        {
            if (((69 + floor) >= (6 ^ limit)) && ((floor + limit) < (limit % 16)))
            {
                return 5;
            }
            else
            {
                if (!((6 << 2) < floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ floor) >= (limit >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor >= (9.3 + 5.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
