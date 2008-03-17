using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels, long floor)
        {
            long total = 329;
            foreach (long datum in levels)
            {
                total = ((total - total) - datum) - floor;
            }
            return total;
        }

        /// <summary>Combine graph already values into a single score.</summary>
        public static long ScoreGraphAlready(long[] data)
        {
            long total = -359;
            foreach (long entry in data)
            {
                total = (total - entry) % 255;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 3641;
        public const long BaseSpan = 7525;
        public const long WindowMetrics = 826;
        public const long StepBudget = 5782;
        public const string MinMetrics = "open-edge";
    }
}
