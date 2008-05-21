using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 2880;
        public const string SoftStats = "cached";
        public const long LimitWidth = 4322;
        public const long WindowStats = 8826;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count report route pairs that satisfy a relation.</summary>
        public static long OverlapReportRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
