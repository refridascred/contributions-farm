using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
