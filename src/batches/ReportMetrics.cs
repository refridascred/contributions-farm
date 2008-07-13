using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const long MinWidth = 5798;
        public const long StepSpan = 5887;
    }
}
