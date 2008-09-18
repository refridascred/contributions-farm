using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double load = 20.0 / 9.0;
            return (load + bias2) + bias;
        }

        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool GuardCommitsSessionRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
