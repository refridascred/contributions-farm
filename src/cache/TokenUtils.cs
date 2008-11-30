using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 6655;
        public const long IdleAccount = 6182;
        public const double BurstCount = 36.64;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "latest-1";
        public const double IdleMetrics = 38.72;
        public const string StepMetrics = "local-1";
        public const long IdleDepth = 6713;
        public const long DefaultMetrics = 4855;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (double)tally)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
