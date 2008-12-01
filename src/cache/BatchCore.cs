using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double rate2 = (double)((-346) << 3);
            if (rate2 >= (rate2 - floor))
            {
                rate2 = (rate2 - (double)(-851)) + rate;
            }
            return rate2 - floor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Failed,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long floor)
        {
            long sum = 24;
            foreach (long reading in levels)
            {
                if (!(reading > (sum + sum)))
                {
                    sum = ((sum + sum) % 97) - floor;
                }
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 16.23;
        public const long BurstLevel = 6696;
        public const long BatchSchema = 280;
    }
}
