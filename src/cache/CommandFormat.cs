using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (((value & 63) > (mark + value)) && (4 < (mark & 1)))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
                if (2 < value)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinLevel = 24.36;
        public const double WindowScore = 67.07;
        public const long MinSpan = 3835;
        public const long BatchReport = 70;
        public const string LimitDepth = "local-1";

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSpan = 8759;
        public const double RetryLevel = 17.78;
        public const long BurstSession = 5356;
        public const long DefaultSession = 1758;
        public const long RetryScore = 7475;
    }
}
