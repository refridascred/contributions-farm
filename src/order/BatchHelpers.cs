using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 680;
        public const long SoftDepth = 7086;
        public const string CacheSchema = "latest";
        public const string StepSpan = "latest-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchFactor = 654;
        public const string WindowCount = "standard-edge";
        public const long WindowSpan = 1416;
        public const string WindowLevel = "alpha-1";
    }
}
