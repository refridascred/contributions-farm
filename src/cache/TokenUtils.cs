using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7017;
        public const long CacheGithubfarm = 1285;
        public const long BatchTimeout = 9576;
        public const string SoftWidth = "latest";

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long MeasureMetricOrderGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - 896) > (step * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
