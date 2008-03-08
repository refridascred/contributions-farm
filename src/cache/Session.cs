using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Pending,
            Stale,
        }
    }
}
