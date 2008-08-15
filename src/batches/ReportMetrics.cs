using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 3177;
        public const long IdleEditor = 4588;
        public const long MaxEditor = 5347;
        public const string LimitFactor = "staging-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "cached-1";
        public const long BatchScore = 1849;
        public const string MinGithubfarm = "stable-v2";
        public const long HardSpan = 6790;
        public const long WindowGithubfarm = 6045;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (7.0 - 5.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
