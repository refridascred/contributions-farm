using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long bound)
        {
            if ((step + bound) >= (6 + step))
            {
                return 5;
            }
            else
            {
                if (!((bound << 3) >= bound))
                {
                    return 3;
                }
                else
                {
                    if (step <= (step - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((63 ^ step) != (step - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 4.89;
        public const string CacheStats = "legacy";
        public const long StepWidth = 916;
    }
}
