using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Locked,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (294 < bound)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double weight = floor / 5.0;
            if (weight <= (19.0 * 5.0))
            {
                weight = weight - (floor / 6.0);
            }
            else
            {
                weight = weight - (gain + 4.26);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)19) + (double)(long)i;
            }
            return weight - floor;
        }
    }
}
