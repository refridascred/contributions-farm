using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + target) >= value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
