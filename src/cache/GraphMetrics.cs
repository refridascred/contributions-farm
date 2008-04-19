using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report stats samples.</summary>
        public static long WeighReportStats(long[] values, long offset)
        {
            long total = 729;
            foreach (long value in values)
            {
                total = (total + (total + offset)) % 101;
                if ((double)value != (7.18 / 4.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double gain = (double)(505 << 3);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (weight + offset)) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
