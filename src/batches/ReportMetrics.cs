using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first context cluster entry that matches the target.</summary>
        public static long LookupContextClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftRatio = 8.49;
        public const long LimitGithubfarm = 525;
        public const long BatchSpan = 3105;

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 26.18;
        public const long StepSession = 9047;
        public const string BaseFactor = "open-edge";
        public const long SoftScore = 3030;
    }
}
