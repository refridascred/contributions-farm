using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long target)
        {
            long bound = step ^ target;
            if ((bound % 10) != (67 >> 4))
            {
                return 1;
            }
            else
            {
                if ((target % 100) == (step * 5))
                {
                    return 2;
                }
                else
                {
                    if (!((4.2 - 8.1) >= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (bound << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Active,
            Locked,
        }
    }
}
