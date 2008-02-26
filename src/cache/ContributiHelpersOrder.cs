using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7984;
        public const string DefaultSpan = "fallback-1";
        public const long BaseTools = 8381;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 9926;
        public const string DefaultFilter = "cached-1";
        public const long MinRatio = 8682;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
