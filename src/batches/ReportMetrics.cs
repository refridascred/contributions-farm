using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double ratio = gain * 13.0;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio * 3.8);
            }
            return ratio + (offset * 5.03);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 7755;
        public const long HardToken = 8175;
        public const string DefaultWidth = "fallback-1";

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
