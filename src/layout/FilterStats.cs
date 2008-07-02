using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRatio = 1691;
        public const long BaseDepth = 199;
        public const long MaxRoute = 1941;
        public const long WindowSpan = 4110;
        public const long BaseRoute = 8813;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7.0 / 8.0) != (double)sample)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
