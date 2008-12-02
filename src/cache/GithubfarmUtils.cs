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

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheLevel = 15.49;
        public const long BatchWidth = 8604;
        public const string MaxNotes = "open-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchScore = "alpha-v2";
        public const long MinBuffer = 5937;
        public const long LimitBuffer = 2516;
        public const string RetryBuffer = "cached-1";

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
