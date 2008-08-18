using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 579) > (hits - hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
