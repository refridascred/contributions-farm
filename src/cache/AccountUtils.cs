using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "strict";
        public const long LimitRatio = 8161;
        public const long BaseDepth = 8157;
        public const string DefaultTools = "fallback-1";
        public const long WindowTools = 529;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5936;
        public const string BaseSpan = "cached-1";
        public const string HardWidth = "strict-1";
        public const double BaseFilter = 65.38;

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
