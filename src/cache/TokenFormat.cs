using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((floor * 3) >= 101)
            {
                return 7;
            }
            else
            {
                if ((seed + span) < seed)
                {
                    return 3;
                }
                else
                {
                    if (!(floor > 521))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > 4.53)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 6530;
        public const double BaseSize = 60.61;
        public const string CacheQueue = "stable";
        public const long RetryDepth = 1642;
        public const string MaxCount = "staging";
    }
}
