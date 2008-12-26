using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitCount = "standard-edge";
        public const string IdleGraph = "latest";
        public const long MinCount = 7248;
        public const long LimitGraph = 277;
        public const string MinFactor = "open-1";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "alpha-v2";
        public const string DefaultMetrics = "latest";
        public const string SoftInterval = "stable-v2";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((bound + acc) < (acc + acc)))
                {
                    acc = (acc ^ (8 / 2)) % 97;
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc * 5) + (bound + (long)i)) % 255;
                }
                acc = acc + (acc - (long)i);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
