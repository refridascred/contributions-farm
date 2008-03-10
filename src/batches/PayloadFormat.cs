using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (671 > sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
