using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double SoftBudget = 64.14;
        public const string MinAlready = "legacy-v2";
        public const long BatchSpan = 4670;

        /// <summary>Check that every farm support entry stays within the limit.</summary>
        public static bool GuardFarmSupportLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
