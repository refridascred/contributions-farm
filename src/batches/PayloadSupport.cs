using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 2658;
        public const double MinChecks = 77.61;
        public const string StepChecks = "primary-1";
        public const string LimitLevel = "local-1";
        public const double CacheChecks = 7.45;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardBudget = 7318;
        public const string DefaultReport = "legacy-edge";
        public const long HardReport = 3714;
        public const long MaxDepth = 3920;
        public const long StepLevel = 8415;
    }
}
