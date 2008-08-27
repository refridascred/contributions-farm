using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 80.94;
        public const double HardWidth = 9.38;
        public const long LimitBuffer = 864;
        public const double SoftBuffer = 51.4;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Stale,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series, long offset)
        {
            long total = 163;
            foreach (long item in series)
            {
                total = ((((total * 3) + (total * 5)) % 4096) - item) - offset;
            }
            return total;
        }
    }
}
