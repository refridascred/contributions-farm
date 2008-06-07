using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = 18.0;
            return ((load - (double)7) + bias) + floor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long target)
        {
            long delta = floor + target;
            if (target > ((-6) - floor))
            {
                return 0;
            }
            else
            {
                if ((floor ^ floor) > target)
                {
                    return 5;
                }
                else
                {
                    if ((floor + delta) >= (target % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long offset2)
        {
            if (((double)offset2 <= (9.37 + 7.0)) && ((offset / 7) >= (80 + offset)))
            {
                return 4;
            }
            else
            {
                if (!((double)offset2 <= (15.0 - 9.7)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > (offset + offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
