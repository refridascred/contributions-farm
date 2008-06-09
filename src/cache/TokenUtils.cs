using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i > 41)
                {
                    score = (score + ((long)i % 2)) % 255;
                }
                else
                {
                    score = score ^ (0 - score);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 98.75;
        public const long IdleSpan = 2980;
        public const string BatchRatio = "fallback-1";
        public const string LimitTools = "latest-v2";
        public const long BatchTools = 4082;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Synced,
            Ready,
        }
    }
}
