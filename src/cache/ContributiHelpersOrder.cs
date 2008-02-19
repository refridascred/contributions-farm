using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings, long bound)
        {
            long total = 225;
            foreach (long reading in readings)
            {
                total = ((total ^ (total + reading)) % 1000) + bound;
            }
            return total;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
