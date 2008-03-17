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

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 3641;
        public const long BaseSpan = 7525;
        public const long WindowMetrics = 826;
        public const long StepBudget = 5782;
        public const string MinMetrics = "open-edge";
    }
}
