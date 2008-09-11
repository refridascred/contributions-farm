using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 7278;
        public const long StepWidth = 594;
        public const long StepScore = 5061;
        public const string IdleFilter = "local-v2";
        public const long HardFactor = 1102;

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long prev = limit - origin;
            if ((origin >> 2) < prev)
            {
                return 6;
            }
            else
            {
                if ((double)limit >= 5.9)
                {
                    return 0;
                }
                else
                {
                    if ((416 + limit) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Ready,
            Closed,
            Failed,
            Active,
        }
    }
}
