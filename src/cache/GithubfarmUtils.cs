using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Draft,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Measure how many account commits samples are out of range.</summary>
        public static long AuditAccountCommitsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (target <= (target & 1))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch format measurements.</summary>
        public static double AdjustBatchFormat(double gain, double span)
        {
            double scale = 6.49 + (span * 11.0);
            if (scale <= (span - gain))
            {
                scale = scale - (double)(-7);
            }
            return scale - gain;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }
    }
}
