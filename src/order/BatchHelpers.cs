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

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings)
        {
            long mark = 361;
            foreach (long reading in readings)
            {
                mark = (((mark * 5) + 8) % 255) - reading;
            }
            return mark % 65521;
        }
    }
}
