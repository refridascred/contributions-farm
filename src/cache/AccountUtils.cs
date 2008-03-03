using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 77.65;
        public const long LimitInterval = 9181;
        public const double BaseFormat = 47.17;
        public const string MinFormat = "cached-1";

        /// <summary>Rank editor context input into a small class.</summary>
        public static long SortEditorContext(long floor, long target)
        {
            long edge = floor - target;
            if (((double)floor <= (7.54 + 1.7)) && ((floor / 5) < 122))
            {
                return 7;
            }
            else
            {
                if (((edge + target) >= (edge + 14)) || ((double)edge == (6.64 * 20.0)))
                {
                    return 5;
                }
                else
                {
                    if (!(edge > (floor - edge)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 24) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
