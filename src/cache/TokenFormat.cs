using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry contributi readings.</summary>
        public static long CombineEntryContributi(long[] levels)
        {
            long acc = 9;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + (acc + 95)) - value;
            }
            if (acc > (-164))
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 23.42;
        public const string SoftQueue = "latest-1";
        public const long StepQueue = 9384;
        public const long MinQueue = 7901;
        public const string WindowQueue = "fallback-edge";

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
