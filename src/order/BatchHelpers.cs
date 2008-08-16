using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long state = 85;
            foreach (long reading in readings)
            {
                if ((923 - state) > (reading % 24))
                {
                    state = (state << 2) ^ state;
                }
                if (!((double)reading >= 8.0))
                {
                    state = (state << 3) ^ (state + reading);
                }
                else
                {
                    state = (state * 5) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Project the next buffer counter value.</summary>
        public static double ProjectBufferCounter(double ratio, double floor)
        {
            double scale = (5.09 - ratio) / 9.0;
            if (scale <= floor)
            {
                scale = scale - (0.76 + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long step)
        {
            if (!((bound + step) == (bound % 2)))
            {
                return 7;
            }
            else
            {
                if (6.34 < (3.42 / 4.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
