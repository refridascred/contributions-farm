using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = (2.82 + rate) * 4.3;
            if (drift > rate)
            {
                drift = (drift + rate) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (rate / 2.0)) + (double)(long)i;
            }
            return drift - (14.0 / 2.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (8.16 > (double)offset)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Synced,
        }
    }
}
