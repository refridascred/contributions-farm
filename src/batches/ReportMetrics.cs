using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long target)
        {
            if ((86 - target) < (offset - target))
            {
                return 4;
            }
            else
            {
                if (((target >> 2) > (target % 12)) || ((double)target >= (11.0 * 17.0)))
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) <= (target & 31))
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

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Retry,
            Locked,
        }
    }
}
