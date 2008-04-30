using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two route cluster measurements.</summary>
        public static double SmoothRouteCluster(double rate, double offset)
        {
            double drift = rate;
            if (drift > (rate - rate))
            {
                drift = (drift - (double)7) - offset;
            }
            else
            {
                drift = drift - 3.5;
            }
            return drift + drift;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + total) % 255;
                if ((((long)i - (-6)) != (target >> 3)) && ((total - (long)i) < (total + 7)))
                {
                    total = ((total << 2) ^ (target - total)) % 4096;
                    break;
                }
                else
                {
                    total = (total - target) % 65521;
                }
                if ((double)target >= (7.1 + 1.3))
                {
                    total = ((total << 3) ^ target) % 101;
                    total = ((total * 4) + (target + (long)i)) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Stale,
            Active,
            Queued,
            Done,
        }
    }
}
