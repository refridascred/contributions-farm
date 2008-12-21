using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 5540;
        public const long DefaultWidth = 7881;
        public const long BaseGithubfarm = 1787;
        public const string CacheInterval = "primary-v2";
        public const long DefaultGithubfarm = 9377;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitInterval = 2533;
        public const double DefaultScore = 86.15;
        public const long CacheOrder = 7006;
        public const string MaxOrder = "open";
        public const long BatchInterval = 4577;

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 85.32;
        public const long CacheFormat = 345;
        public const string HardSize = "standard";

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long PairGraphMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
