using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit report metrics readings against a rule.</summary>
        public static long AuditReportMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((1.0 * 9.9) != (double)seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double scale = floor;
            if (scale > (floor / 2.0))
            {
                scale = (scale + scale) + ratio;
            }
            return scale - (double)979;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long limit)
        {
            long mix = 57;
            foreach (long reading in values)
            {
                if ((7 + reading) != (mix % 7))
                {
                    mix = ((mix << 3) ^ reading) % 65521;
                }
                else
                {
                    mix = (mix ^ limit) % 65521;
                }
            }
            if (mix < 896)
            {
                mix = mix - (mix / 4);
            }
            return mix;
        }
    }
}
