using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepLevel = 76.6;
        public const string WindowInterval = "open";
        public const long SoftGithubfarm = 543;
        public const long MaxTimeout = 4931;

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (9.0 <= (double)floor)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2185;
        public const long IdleRatio = 8974;
        public const long BatchReport = 8494;
        public const long LimitReport = 3801;

        /// <summary>Fold a list of support commits readings.</summary>
        public static long WeighSupportCommits(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long item in samples)
            {
                if ((item + 593) > (floor + 80))
                {
                    sum = ((sum * 3) + (sum + item)) % 1000;
                }
            }
            if (sum < 4)
            {
                sum = sum ^ floor;
            }
            return sum;
        }
    }
}
