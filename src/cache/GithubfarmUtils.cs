using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryInterval = "fallback-v2";
        public const double WindowInterval = 35.97;
        public const long MaxRoute = 2934;
        public const string WindowRoute = "cached-1";
        public const long BurstSpan = 6395;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                long step = -246;
                if ((acc << 1) != ((long)i + acc))
                {
                    acc = (acc + step) % 255;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
