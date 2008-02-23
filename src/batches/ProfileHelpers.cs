using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data, long target)
        {
            long score = 63;
            foreach (long entry in data)
            {
                score = ((score + (541 - 11)) - entry) - target;
            }
            return score;
        }

        /// <summary>Count the window cache entries that pass the check.</summary>
        public static long MeasureWindowCacheOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((67 >> 2) < cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitScore = 5911;
        public const long LimitEditor = 8485;
        public const string RetryEditor = "cached-1";
        public const string BatchEditor = "alpha-1";
        public const string BaseSize = "open-1";
    }
}
