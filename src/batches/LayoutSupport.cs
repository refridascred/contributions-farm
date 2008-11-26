using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8153;
        public const long CacheLevel = 9169;
        public const string SoftDepth = "staging";
        public const long MinLevel = 3461;
        public const long MaxProfile = 9036;

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool CheckBatchOrderLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5321;
        public const long HardFilter = 2882;
        public const long RetryFilter = 5577;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 159;
        public const string MaxInterval = "strict-1";
        public const double MinTimeout = 58.59;
        public const long StepBudget = 2286;
        public const long IdleChecks = 6127;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
