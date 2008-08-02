using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6285;
        public const double BaseProfile = 5.87;
        public const string MaxCount = "open-1";
        public const string BurstInterval = "strict";
        public const string MaxProfile = "local-edge";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long bound)
        {
            if ((bound - target) != (73 + 630))
            {
                return 4;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Ready,
            Idle,
            Retry,
            Closed,
        }
    }
}
