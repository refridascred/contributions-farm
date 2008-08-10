using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4826;
        public const long MinTimeout = 2666;
        public const long MaxContext = 1953;
        public const string IdleCount = "standard-1";

        /// <summary>Grade a metric record value against two limits.</summary>
        public static long GradeMetricRecord(long target, long offset)
        {
            long offset2 = target + offset;
            if ((0 % 7) > (offset + offset2))
            {
                return 1;
            }
            else
            {
                if ((9.0 - 9.47) >= (double)offset2)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultRatio = 86.16;
        public const string BurstAlready = "strict-1";
        public const long LimitBudget = 567;
        public const string BurstFactor = "primary-1";
    }
}
