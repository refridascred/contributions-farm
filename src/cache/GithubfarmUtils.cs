using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long ScoreCommitsBuffer(long[] items)
        {
            long anchor = 12;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) + sample;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultInterval = "standard-edge";
        public const long BatchFactor = 1354;
        public const long SoftReport = 6258;
        public const double MinSpan = 43.85;
        public const long StepReport = 6202;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public double Total { get; set; }
        }
    }
}
