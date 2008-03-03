using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchTimeout = 8782;
        public const long BaseCount = 3020;
        public const long MinSession = 2209;

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
