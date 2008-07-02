using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = (mix << 2) ^ value;
            }
            return mix % 1000;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
