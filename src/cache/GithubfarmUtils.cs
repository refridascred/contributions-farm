using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitBudget = 8750;
        public const long WindowScore = 9045;
        public const long RetryFactor = 3179;
        public const double HardWidth = 79.72;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length <= (9.61 - 2.9))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 5229;
        public const long WindowWidth = 5799;
        public const long LimitTimeout = 3946;
        public const long WindowEntry = 3341;
    }
}
