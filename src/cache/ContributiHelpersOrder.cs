using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)hits <= (double)entry) || ((hits % 24) < (249 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
