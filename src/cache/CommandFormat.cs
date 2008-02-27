using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2938;
        public const long RetryScore = 2837;
        public const long BatchInterval = 2403;
        public const double BatchTools = 5.68;
        public const long CacheBudget = 4451;
    }
}
