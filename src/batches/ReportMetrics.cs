using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 5863;
        public const long DefaultDepth = 7634;
        public const long IdleSize = 4677;
        public const long BatchMetrics = 3039;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinWidth = 815;
        public const long SoftRoute = 3107;
        public const string RetrySpan = "standard-1";
        public const long WindowRoute = 4856;
    }
}
