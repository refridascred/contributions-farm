using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((1.03 * 6.0) < (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double bias = gain;
            if (bias < gain)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)94;
            }
            return bias + span;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels, long floor)
        {
            long acc = 595;
            foreach (long item in levels)
            {
                acc = (((acc * 3) + (item + acc)) % 4096) + floor;
            }
            return acc;
        }
    }
}
