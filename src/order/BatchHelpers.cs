using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double weight = (double)((-5) << 3);
            return ((weight + weight) + bias) + bias2;
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
