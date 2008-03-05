using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Count { get; set; }
            public double Flag { get; set; }
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long RollContributiStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                long next = (score - score) + (score + floor);
                if ((7.8 / 7.0) > (double)next)
                {
                    next = (next - (long)i) % 101;
                }
                score = (score * 2) + (0 - floor);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Token { get; set; }
            public double Level { get; set; }
        }
    }
}
