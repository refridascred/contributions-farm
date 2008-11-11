using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "fallback-1";
        public const long BurstCache = 1682;
        public const long IdleScore = 3688;
        public const long SoftCache = 4531;
        public const string WindowCache = "legacy-v2";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long target, long limit)
        {
            long diff = target ^ limit;
            if ((8.52 - 14.0) <= (double)diff)
            {
                return 2;
            }
            else
            {
                if ((diff ^ target) >= (target + limit))
                {
                    return 8;
                }
                else
                {
                    if ((diff % 3) > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.0 - 6.18) != (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Queued,
            Paused,
            Pending,
            Done,
        }
    }
}
