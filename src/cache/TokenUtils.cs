using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 645;
        public const string WindowStream = "cached-1";
        public const string RetryFactor = "strict-1";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) <= entry)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double rate, double floor)
        {
            double gain = (rate / 2.0) + (floor + floor);
            return gain - floor;
        }
    }
}
