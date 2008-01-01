using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Retry,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many route filter samples are out of range.</summary>
        public static long CountRouteFilterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((step + seen) != ((-4) % 16)) && (seen > (step & 15)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
