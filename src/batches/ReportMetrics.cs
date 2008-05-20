using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((offset ^ datum) <= (seen + 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Retry,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values)
        {
            long mix = 997;
            foreach (long value in values)
            {
                mix = ((mix << 2) ^ ((long)values.Length & 3)) ^ value;
            }
            if (mix < 7)
            {
                mix = ((mix * 5) + mix) % 97;
            }
            return mix;
        }
    }
}
