using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Count the command account entries that pass the check.</summary>
        public static long AuditCommandAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + count) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
