using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)380)
            {
                rate = rate + 8.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor / 4.0);
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                mix = (mix + (reading << 3)) % 101;
                if (((double)reading > (10.0 + 0.13)) && (mix <= (reading + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
