using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long target)
        {
            if ((bound + 2) >= (bound - bound))
            {
                return 4;
            }
            else
            {
                if (!((bound - target) <= target))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (bound + target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3113;
        public const string RetryTimeout = "fallback-v2";
        public const string BurstCluster = "standard-edge";
        public const long RetryCluster = 6363;
    }
}
