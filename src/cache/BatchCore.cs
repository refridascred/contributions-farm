using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 82.3;
        public const long LimitScore = 2142;
        public const string MinCluster = "fallback-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepTimeout = "strict-edge";
        public const long BaseEntry = 8496;
        public const long MaxDepth = 8993;
        public const long BurstEntry = 9417;

        /// <summary>Locate a githubfarm format reading by value.</summary>
        public static long FindGithubfarmFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
