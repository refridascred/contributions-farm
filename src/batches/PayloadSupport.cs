using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 4547;
        public const string StepRatio = "legacy-v2";
        public const string HardWidth = "local-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "stable";
        public const string CacheBudget = "stable";
        public const string WindowStream = "legacy-1";

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long bound, long offset)
        {
            if (((offset & 7) > (offset / 8)) && ((7.7 + 4.34) == (double)bound))
            {
                return 0;
            }
            else
            {
                if ((285 / 4) <= (bound * 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
