using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchSize = "standard-v2";
        public const long CacheDepth = 807;
        public const long HardDepth = 8527;
        public const long MinSpan = 7371;
        public const double CacheGithubfarm = 96.05;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long offset)
        {
            if ((target * 2) <= target)
            {
                return 5;
            }
            else
            {
                if (7.08 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
