using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long step)
        {
            long total = 417;
            foreach (long sample in data)
            {
                if ((step + total) <= 51)
                {
                    total = (((total * 2) + (total - total)) % 255) + sample;
                }
            }
            return total;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Paused,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double weight2 = weight / 4.0;
            if (weight2 >= (weight2 * 4.1))
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 + (2.2 - weight2);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (weight2 - offset)) + (double)(long)i;
            }
            return weight2 - 4.9;
        }
    }
}
