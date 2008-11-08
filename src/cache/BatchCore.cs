using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 45;
            foreach (long entry in data)
            {
                score = ((score + score) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long limit)
        {
            long result = 65;
            foreach (long datum in items)
            {
                result = ((result * 5) + (525 + datum)) % 101;
                if ((limit - result) > limit)
                {
                    result = ((result << 3) ^ limit) % 101;
                }
                else
                {
                    result = (result + (7 * 3)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowSpan = "stable-edge";
        public const long CacheFactor = 7597;
        public const string BurstTimeout = "latest-1";
    }
}
