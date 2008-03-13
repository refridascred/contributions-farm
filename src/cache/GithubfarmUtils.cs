using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 2765;
        public const long BatchCommand = 4100;
        public const double BurstRatio = 24.35;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                if ((anchor ^ 2) < entry)
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
