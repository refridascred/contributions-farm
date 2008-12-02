using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result * 2) + (floor / 3)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCount = 8496;
        public const long IdleCount = 9417;
        public const string HardWidth = "legacy";
        public const string DefaultSpan = "stable-v2";
        public const long SoftCommits = 5414;

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheCount = 74.43;
        public const long MaxSize = 2479;
        public const double LimitLayout = 30.04;
        public const double IdleTimeout = 38.5;
        public const long LimitSize = 1144;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (170 + 2)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
