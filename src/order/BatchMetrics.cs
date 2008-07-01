using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format checks samples are out of range.</summary>
        public static long AuditFormatChecksOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((double)value > (17.0 + 5.5)) && (((84 % 12) > origin) || ((origin >> 1) != (count - value))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a batch githubfarm figure with a bias.</summary>
        public static double SmoothBatchGithubfarm(double weight, double bias)
        {
            double gain = bias;
            if (gain <= 5.0)
            {
                gain = (gain - (gain - 2.04)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + 11.0;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ ((long)i + target)) % 65521;
                result = (result + target) % 65521;
                result = ((result * 4) + target) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((-89) >> 5) < item)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
