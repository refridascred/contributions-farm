using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two report tools measurements.</summary>
        public static double SmoothReportTools(double bias, double span)
        {
            double gain = bias;
            if (gain >= (bias * 7.0))
            {
                gain = gain - (span + 5.96);
            }
            return gain - 1.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 23.15;
        public const double SoftCount = 31.29;
        public const double StepRecord = 51.45;
        public const long DefaultRecord = 3727;
    }
}
