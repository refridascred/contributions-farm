using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheInterval = 49.94;
        public const double MinRatio = 71.49;
        public const string BatchStream = "open";

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 9013;
        public const double LimitRatio = 5.31;
        public const long StepInterval = 9922;
        public const long MinRoute = 9923;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long limit)
        {
            if ((2.3 - 3.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if (3 <= (limit + origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
