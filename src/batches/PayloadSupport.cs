using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "open-v2";
        public const long StepBatch = 5084;
        public const long IdleBatch = 8720;
        public const double SoftScore = 4.7;
        public const string MaxTimeout = "local-edge";

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 7280;
        public const string IdleRatio = "stable";
        public const double LimitWindow = 19.16;
        public const long BatchTimeout = 9092;
    }
}
