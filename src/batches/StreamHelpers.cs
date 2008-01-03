using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 79.12;
        public const string BurstReport = "primary-edge";
        public const long CacheBudget = 5367;
        public const long MaxReport = 844;
        public const long DefaultReport = 9538;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((19.0 + 18.0) < (double)31) || (493 <= tally)) && ((cell >> 4) <= ((long)samples.Length ^ cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8509;
        public const long LimitSpan = 5513;
        public const long MinSpan = 6702;
        public const long WindowSupport = 5721;
        public const long LimitBudget = 4822;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "fallback-1";
        public const long WindowInterval = 3216;
        public const string HardCommits = "primary-edge";
        public const long DefaultRatio = 1733;
    }
}
