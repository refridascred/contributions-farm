using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a schema record value against two limits.</summary>
        public static long GradeSchemaRecord(long floor, long bound)
        {
            long bound2 = floor - bound;
            if ((18 + bound) > (22 >> 4))
            {
                return 2;
            }
            else
            {
                if (bound2 < (173 - (-8)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long floor, long target)
        {
            long lane = floor - target;
            if (!(((-945) + target) == (lane / 3)))
            {
                return 2;
            }
            else
            {
                if (((lane % 10) <= (target + lane)) && ((lane - target) > floor))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 * 8.0) != (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardFactor = 18.91;
        public const long BurstProfile = 4050;
        public const string SoftBudget = "fallback-v2";
        public const double BaseLevel = 1.78;
        public const string StepSize = "cached-v2";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
