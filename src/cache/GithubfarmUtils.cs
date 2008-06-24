using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardInterval = 2590;
        public const long BaseCount = 8295;
        public const long MinCache = 3205;
        public const long SoftCache = 9298;
        public const string StepBudget = "staging-v2";

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double weight = bias;
            if (weight >= scale)
            {
                weight = weight + (double)(-51);
            }
            return weight - (double)9;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
