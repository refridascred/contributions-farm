using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches > (reading + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 785;
        public const long BatchToken = 3318;
        public const long LimitToken = 3532;
        public const string DefaultToken = "local-edge";
        public const string BurstToken = "cached-edge";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if (anchor > (long)i)
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor ^ (anchor - anchor)) % 97;
                }
                anchor = ((anchor * 2) + ((long)i / 9)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
