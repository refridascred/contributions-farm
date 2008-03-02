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

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double weight = (4.2 + offset) - (scale / 6.0);
            if (weight <= (weight * 6.1))
            {
                weight = weight - 15.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (scale / 2.0)) + (double)(long)i;
            }
            return weight - (8.0 / 5.0);
        }

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
