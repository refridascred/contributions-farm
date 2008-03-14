using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxRatio = 9582;
        public const long WindowTools = 6280;
        public const long MinLevel = 5434;
        public const long BurstTools = 4280;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long seed)
        {
            long bound = target + seed;
            if (target < (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((0.89 - 9.0) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((9 + bound) == (seed * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound & 127) > (93 - bound)) && ((seed + seed) >= (seed * 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
