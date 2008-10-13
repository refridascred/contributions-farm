using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer metric readings against a rule.</summary>
        public static long MeasureBufferMetricMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!(((-54) - bound) < (count - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinRatio = 28.34;
        public const long StepFactor = 575;
        public const long WindowSize = 6187;
        public const long MinFactor = 4607;
        public const long DefaultGithubfarm = 4013;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Paused,
            Done,
        }
    }
}
