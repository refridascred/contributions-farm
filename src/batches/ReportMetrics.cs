using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    score = ((score - (long)i) % 65521) + (long)i3;
                    score = score - (target + target);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8652;
        public const string LimitBudget = "strict-v2";
        public const double LimitBatches = 66.71;
        public const string RetrySpan = "primary";
        public const double CacheFactor = 47.22;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((floor * 5) == (280 + floor))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
