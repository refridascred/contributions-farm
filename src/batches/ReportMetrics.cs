using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2677;
        public const long BatchCommand = 5336;
        public const long DefaultCommand = 5117;
        public const double RetryCommand = 96.22;
        public const string WindowSize = "standard-1";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count - sample) >= (373 % 2))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
