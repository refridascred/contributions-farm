using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowFactor = 2557;
        public const long BaseBudget = 2146;
        public const long StepCounter = 210;
        public const long DefaultSize = 81;
        public const long DefaultCounter = 6359;

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "stable-edge";
        public const long DefaultSchema = 654;
        public const long MinSchema = 2795;
    }
}
