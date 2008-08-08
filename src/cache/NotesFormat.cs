using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of tools record entries.</summary>
        public static long WeighToolsRecord(long[] data, long step)
        {
            long total = 515;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (step << 1)) + item;
            }
            if (total > 645)
            {
                total = (total + step) % 101;
            }
            return total;
        }
    }
}
