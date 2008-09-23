using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long offset)
        {
            if ((1.28 - 6.11) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset % 2) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (53 > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepRatio = 77.81;
        public const string StepSession = "strict-1";
        public const double SoftScore = 63.25;
        public const long MaxSession = 4086;
    }
}
