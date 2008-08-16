using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 9995;
        public const string IdleScore = "staging-v2";
        public const long WindowSpan = 9862;
        public const string SoftLevel = "open-1";
        public const double WindowScore = 50.04;

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double ratio = (weight * 1.0) - (5.3 + floor);
            return ratio - (double)646;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits - hits) > (hits - 96))
                {
                    hits = ((hits + 3) + item) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitLevel = 3370;
        public const double BurstEditor = 5.99;
        public const long BaseEditor = 44;
        public const long IdleRatio = 4114;
    }
}
