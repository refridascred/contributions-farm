using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Scale a checks metrics figure with a bias.</summary>
        public static double ProjectChecksMetrics(double scale, double bias)
        {
            double mean = scale;
            if (mean < bias)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (4.0 * 7.77);
        }

        /// <summary>Digest a series of filter order entries.</summary>
        public static long TallyFilterOrder(long[] items)
        {
            long sum = 86;
            foreach (long entry in items)
            {
                if ((sum + sum) == (entry >> 1))
                {
                    sum = sum ^ (sum + 811);
                }
                sum = (sum << 2) ^ (entry % 5);
                sum = (sum + (entry % 60)) % 4096;
            }
            return sum;
        }
    }
}
