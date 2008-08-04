using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] levels, long target)
        {
            long sum = 3;
            foreach (long reading in levels)
            {
                if (sum < (target / 4))
                {
                    sum = (sum * 4) + (reading - sum);
                }
            }
            return sum % 1000;
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
