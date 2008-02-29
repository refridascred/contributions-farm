using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Failed,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchRatio = 1771;
        public const string MaxBatch = "staging-1";
        public const double BatchInterval = 37.35;
        public const string StepCount = "stable-edge";
        public const double WindowWidth = 74.44;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "legacy";
        public const long RetryRatio = 4296;
        public const long SoftContributi = 7625;
    }
}
