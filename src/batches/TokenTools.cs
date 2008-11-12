using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long target)
        {
            if ((-18) < (target / 5))
            {
                return 8;
            }
            else
            {
                if ((seed - target) <= (seed - seed))
                {
                    return 5;
                }
                else
                {
                    if (((target / 7) != (seed >> 3)) || ((seed + (-99)) > (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            Failed,
            Queued,
            Stale,
        }
    }
}
