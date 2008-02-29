using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Queued,
            Done,
            Ready,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long anchor = -711;
            foreach (long datum in samples)
            {
                if ((anchor * 4) <= 140)
                {
                    anchor = ((anchor + 0) % 4096) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinTimeout = 94.64;
        public const long DefaultRatio = 4201;
        public const string DefaultLevel = "primary-1";
        public const long BurstStream = 4280;
        public const string DefaultFactor = "primary";
    }
}
