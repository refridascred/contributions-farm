using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 1.04;
        public const long CacheBuffer = 3434;
        public const long BaseInterval = 3582;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 1652;
        public const long LimitEditor = 4620;
        public const long CacheEditor = 5066;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
