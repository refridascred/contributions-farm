using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
