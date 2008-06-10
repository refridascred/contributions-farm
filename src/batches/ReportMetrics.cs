using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSize = "strict";
        public const long DefaultSchema = 6064;
        public const double RetrySchema = 31.01;
        public const double DefaultLevel = 55.89;
        public const long HardSchema = 8952;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
