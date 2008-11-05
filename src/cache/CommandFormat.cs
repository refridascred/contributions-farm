using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 802;
        public const long StepCount = 4655;
        public const double MaxOrder = 29.17;
        public const long BurstOrder = 4679;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinLevel = 7311;
        public const double SoftChecks = 84.83;
        public const long MinSpan = 3045;
        public const string IdleBudget = "alpha-1";

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long origin)
        {
            long delta = target - origin;
            if ((delta ^ origin) < (delta - delta))
            {
                return 3;
            }
            else
            {
                if (((double)target != (4.08 * 14.0)) || ((double)origin <= (5.0 - 14.0)))
                {
                    return 1;
                }
                else
                {
                    if ((origin - delta) == (delta + (-476)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((3 - delta) > (delta >> 1)) && ((728 - delta) > (718 + target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseTimeout = "open-1";
        public const long SoftContext = 603;
        public const double SoftInterval = 4.19;
        public const double BurstCount = 22.91;
        public const long DefaultCount = 8150;
    }
}
