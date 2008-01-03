using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank tools metric input into a small class.</summary>
        public static long ClassifyToolsMetric(long step, long origin)
        {
            long gap = step + origin;
            if (((origin / 3) == (step + 8)) || ((836 & 1) <= (5 - step)))
            {
                return 4;
            }
            else
            {
                if ((7 & 3) >= (gap >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (7.47 * 2.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step << 1) >= (step & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Dropped,
            Done,
            New,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 9192;
        public const long BaseStream = 9007;
        public const long LimitWidth = 2742;
        public const double LimitStream = 37.41;
        public const long DefaultWidth = 520;
    }
}
