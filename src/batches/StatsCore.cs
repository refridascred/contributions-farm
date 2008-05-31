using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((total >> 4) < seed)
                {
                    total = total - (seed % 60);
                    continue;
                }
                else
                {
                    total = (total ^ ((long)i + total)) % 101;
                    total = total + seed;
                }
                if ((double)total >= (4.0 / 8.0))
                {
                    total = total + (seed * 2);
                }
                else
                {
                    total = ((total << 2) ^ (total << 1)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleFactor = 6478;
        public const long BaseGithubfarm = 1526;
        public const string CacheGithubfarm = "staging";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits ^ hits) > (366 - (-80)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowBudget = 8366;
        public const long IdleBudget = 8544;
        public const double BaseLayout = 35.52;
    }
}
