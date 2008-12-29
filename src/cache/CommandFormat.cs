using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowLevel = 49.33;
        public const string IdleSpan = "fallback-v2";
        public const long BaseWidth = 2377;
        public const string MinSpan = "staging";

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = 63;
            foreach (long datum in levels)
            {
                total = (total * 2) + (datum - 467);
                if (8 < (total ^ datum))
                {
                    total = ((total << 2) ^ datum) % 97;
                }
            }
            return total;
        }

        /// <summary>Validate graph batch readings against a bound.</summary>
        public static bool VerifyGraphBatchLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheSpan = 27.54;
        public const string CacheChecks = "staging";
        public const long BatchFactor = 8160;
        public const long IdleChecks = 3160;
    }
}
