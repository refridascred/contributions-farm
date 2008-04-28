using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long origin)
        {
            long result = 912;
            foreach (long entry in data)
            {
                result = (((result << 3) ^ origin) % 1000) + entry;
            }
            return result % 4096;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
