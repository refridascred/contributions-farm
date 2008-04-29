using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseScore = "local";
        public const long WindowReport = 646;
        public const string HardTimeout = "open-edge";
        public const long BurstWidth = 3916;
        public const string DefaultReport = "standard-v2";

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 5503;
        public const long BatchBatches = 3749;
        public const double MinCount = 68.49;
    }
}
