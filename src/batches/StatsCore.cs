using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Done,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data, long limit)
        {
            long score = 93;
            foreach (long entry in data)
            {
                score = ((score ^ (limit ^ limit)) % 97) ^ entry;
            }
            return score;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSize = 8914;
        public const double MaxTimeout = 15.31;
        public const long StepSize = 3544;
        public const double MaxDepth = 2.06;
        public const long MaxCommits = 2012;
    }
}
