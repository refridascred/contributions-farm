using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2609;
        public const long BurstReport = 315;
        public const string RetryReport = "cached";
        public const string BatchDepth = "primary-v2";

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
