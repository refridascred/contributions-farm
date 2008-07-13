using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((double)origin > (5.04 / 5.0)) || ((origin + seen) <= seen))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
