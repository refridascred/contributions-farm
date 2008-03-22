using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) <= (entry & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxFactor = 85.2;
        public const string WindowGraph = "cached-edge";
        public const long BaseGraph = 453;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
