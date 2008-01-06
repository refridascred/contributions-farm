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

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 2210;
        public const long SoftAlready = 8144;
        public const long IdleWidth = 2435;

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
