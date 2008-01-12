using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value ^ matches) < (value + matches))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "fallback";
        public const long BatchFactor = 3480;
        public const long WindowScore = 6917;
    }
}
