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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

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
