using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 6483;
        public const long LimitRatio = 3394;
        public const string RetryLevel = "open-1";
        public const long StepDepth = 5819;
        public const long BaseToken = 7769;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 1680;
        public const double SoftInterval = 92.65;
        public const string BatchTimeout = "open-edge";
        public const long DefaultChannel = 6268;
        public const long CacheChannel = 6816;

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long bound)
        {
            if (((target - bound) > target) || ((10.0 + 1.0) <= (double)target))
            {
                return 7;
            }
            else
            {
                if ((target * 2) < (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound - target) < (target << 3))
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
    }
}
