using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a contributi record reading.</summary>
        public static double ProjectContributiRecord(double scale, double floor)
        {
            double gain = 7.02;
            return (gain + scale) + floor;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long offset)
        {
            long gap = step ^ offset;
            if ((6.27 - 0.2) == (double)step)
            {
                return 6;
            }
            else
            {
                if ((81 + 12) < (step * 5))
                {
                    return 8;
                }
                else
                {
                    if (!(gap >= (step * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap >> 2) >= (gap >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long bound)
        {
            long bound2 = target - bound;
            if ((605 / 9) >= (bound - bound2))
            {
                return 2;
            }
            else
            {
                if ((bound2 << 3) < 685)
                {
                    return 5;
                }
                else
                {
                    if (((bound2 ^ bound) > bound2) && ((target >> 2) > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
