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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((797 - (long)items.Length) > (step / 5))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
