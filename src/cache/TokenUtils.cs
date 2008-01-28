using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 31.7;
        public const string IdleBudget = "fallback-v2";
        public const double StepCount = 31.57;
        public const long CacheRatio = 397;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long limit, long seed)
        {
            if (seed >= limit)
            {
                return 7;
            }
            else
            {
                if ((double)seed == (8.89 + 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 4) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Synced,
            Idle,
            Locked,
        }
    }
}
