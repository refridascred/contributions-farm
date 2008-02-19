using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((1.8 + 8.8) == (double)origin)
                {
                    anchor = (anchor ^ (origin << 2)) % 65521;
                }
                else
                {
                    anchor = (anchor + origin) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultDepth = "latest-1";
        public const long DefaultStream = 1330;
        public const string BurstStream = "open-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5474;
        public const string CacheSchema = "strict-1";
        public const double DefaultSchema = 87.85;
        public const long MaxCount = 8484;
        public const double SoftSchema = 55.44;
    }
}
