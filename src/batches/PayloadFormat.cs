using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxTimeout = "primary-edge";
        public const string DefaultBatch = "strict";
        public const string HardFactor = "fallback";
        public const long MaxRatio = 4236;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
