using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Adjust a report format reading.</summary>
        public static double ProjectReportFormat(double weight, double bias)
        {
            double load = weight;
            if (load < (bias / 3.0))
            {
                load = load + (bias + load);
            }
            else
            {
                load = load - (double)351;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (bias + bias)) - (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((757 * 4) >= cell)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
