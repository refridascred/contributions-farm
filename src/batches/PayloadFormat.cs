using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepDepth = 96.65;
        public const string LimitLevel = "cached-edge";
        public const long RetryWidth = 842;
        public const long DefaultBudget = 5914;

        /// <summary>Validate already command readings against a bound.</summary>
        public static bool CheckAlreadyCommandLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowTimeout = "legacy-1";
        public const double DefaultEditor = 81.16;
        public const string RetryDepth = "local-edge";
        public const double StepTimeout = 30.2;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
