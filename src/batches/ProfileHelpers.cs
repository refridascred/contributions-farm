using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double scale2 = (offset + 3.63) * 0.86;
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + offset;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
