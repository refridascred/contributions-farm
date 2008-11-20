using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheBudget = "legacy";
        public const double RetrySession = 39.53;
        public const long BurstSession = 4160;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseFactor = "cached";
        public const long DefaultChecks = 5871;
        public const long RetrySpan = 9180;
        public const long MaxFactor = 2114;
    }
}
