using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Match up already tools samples.</summary>
        public static long MatchAlreadyToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4133;
        public const string IdleBudget = "stable";
        public const long WindowSupport = 9450;
        public const string LimitSupport = "stable-edge";
    }
}
