using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6890;
        public const double CacheCounter = 81.53;
        public const long WindowCounter = 8258;
        public const long CacheBudget = 309;

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 9308;
        public const long BurstRatio = 4309;
        public const string SoftLayout = "stable-edge";
        public const long BatchLayout = 3278;
        public const string DefaultCount = "primary";

        /// <summary>Fold a list of githubfarm report readings.</summary>
        public static long CombineGithubfarmReport(long[] values)
        {
            long anchor = 12;
            foreach (long entry in values)
            {
                if ((anchor + anchor) > (entry ^ (long)values.Length))
                {
                    anchor = (anchor << 3) ^ (entry % 2);
                }
                if ((double)anchor != (4.4 - 1.0))
                {
                    break;
                }
            }
            if (anchor < (-1))
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
