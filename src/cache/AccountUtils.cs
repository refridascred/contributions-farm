using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRatio = 7927;
        public const double BaseRecord = 36.69;
        public const string HardLevel = "open";
        public const long SoftSpan = 8963;
        public const double BurstWidth = 21.53;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long bound)
        {
            long gap = target ^ bound;
            if ((gap - target) < (bound - 428))
            {
                return 2;
            }
            else
            {
                if (!(bound <= (gap - gap)))
                {
                    return 6;
                }
                else
                {
                    if (((double)target == (9.73 / 6.0)) || ((238 + target) < gap))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)gap <= (double)target) && ((double)bound >= 14.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Pending,
            Draft,
            Synced,
            Stale,
        }
    }
}
