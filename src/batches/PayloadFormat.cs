using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 61.93;
        public const long MaxContext = 6907;
        public const string BaseContext = "standard-1";
        public const long StepDepth = 3925;
        public const long MinContext = 8770;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftInterval = 8667;
        public const string IdleBatches = "fallback-1";
        public const long BurstWidth = 9929;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Stale,
            Draft,
            Dropped,
        }
    }
}
