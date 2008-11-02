using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepDepth = "staging-1";
        public const double CacheDepth = 4.0;
        public const long DefaultMetrics = 7361;
        public const long BaseMetrics = 6397;

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                sum = (sum ^ sum) ^ cell;
                if (((4.5 * 7.64) > (double)limit) || (0 >= (limit % 16)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two buffer editor measurements.</summary>
        public static double ProjectBufferEditor(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - (weight + floor);
        }
    }
}
