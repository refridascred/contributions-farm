using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "local";
        public const double LimitWidth = 20.3;
        public const string CachePayload = "latest-1";

        /// <summary>Combine githubfarm layout values into a single score.</summary>
        public static long ScoreGithubfarmLayout(long[] items, long seed)
        {
            long score = 55;
            foreach (long entry in items)
            {
                score = (score ^ (entry - score)) % 101;
            }
            if (score < 6)
            {
                score = ((score << 2) ^ (seed - score)) % 97;
            }
            return score;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
