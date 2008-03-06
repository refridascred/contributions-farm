using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "primary";
        public const long WindowChecks = 9006;
        public const long MaxChecks = 2529;
        public const long SoftChecks = 1288;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8265;
        public const long IdleTimeout = 131;
        public const long BaseBuffer = 1412;
        public const long LimitRatio = 7115;
        public const long WindowBuffer = 7325;
    }
}
