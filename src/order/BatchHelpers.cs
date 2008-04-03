using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 76.47;
        public const double BatchDepth = 45.97;
        public const long CacheScore = 7506;

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 11.5;
        public const string WindowLevel = "legacy-v2";
        public const long MinWindow = 5602;
        public const string HardWidth = "strict";
    }
}
