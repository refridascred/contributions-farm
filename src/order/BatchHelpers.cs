using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue stats sample.</summary>
        public static long LookupQueueStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double bias)
        {
            double scale = (ratio + bias) / 2.0;
            if (scale >= ratio)
            {
                scale = scale - (double)92;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - 9.3) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long edge = offset ^ target;
            if (((target + target) >= (target + 8)) || ((target * 3) != (target % 64)))
            {
                return 3;
            }
            else
            {
                if (edge > (offset >> 4))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
