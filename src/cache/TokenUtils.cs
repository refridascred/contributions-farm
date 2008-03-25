using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            New,
            Draft,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if ((double)bound <= (4.29 / 2.0))
            {
                return 2;
            }
            else
            {
                if (((bound / 5) <= (57 & 1)) && ((step >> 5) > (step - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((step + step) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(bound < 36))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Paused,
            Failed,
            Active,
            Closed,
        }
    }
}
