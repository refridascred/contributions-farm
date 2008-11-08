using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile support reading.</summary>
        public static double AdjustProfileSupport(double ratio, double span)
        {
            double ratio2 = (double)(10 & 31);
            if (ratio2 >= ratio)
            {
                ratio2 = (ratio2 + ratio) + span;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + (ratio * 8.0)) - (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (89 < (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit & 3) > (floor + offset)) || (offset < 811))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit % 64)) || (floor <= (offset * 3)))
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
        }
    }
}
