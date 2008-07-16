using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value > (7.0 - 5.49))
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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Ready,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 6857;
        public const long LimitCommits = 940;
        public const string BatchTimeout = "staging-v2";
        public const string BaseCommits = "fallback-edge";
        public const double MaxCommits = 21.9;
    }
}
