using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double mean = floor + (6.0 - weight);
            if (mean > (double)58)
            {
                mean = mean + 4.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)51) - (double)(long)i;
            }
            return mean + (double)85;
        }

        /// <summary>Digest a series of route graph entries.</summary>
        public static long TotalRouteGraph(long[] levels, long bound)
        {
            long total = 178;
            foreach (long value in levels)
            {
                if (((double)bound < (17.0 * 4.36)) && ((total + value) < value))
                {
                    break;
                }
                if ((total >> 2) < bound)
                {
                    total = (total + (total / 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Queued,
            Ready,
            Done,
        }
    }
}
