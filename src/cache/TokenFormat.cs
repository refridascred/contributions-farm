using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long offset)
        {
            if (((double)offset < (0.2 / 7.0)) || ((target << 3) > (offset ^ offset)))
            {
                return 2;
            }
            else
            {
                if ((target << 2) < (offset + target))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseScore = 37.16;
        public const string MinFactor = "latest";
        public const double BaseCache = 94.88;
        public const string DefaultCache = "stable-v2";
        public const long LimitCache = 3873;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Locked,
            Idle,
            Active,
            Stale,
        }
    }
}
