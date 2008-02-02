using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
