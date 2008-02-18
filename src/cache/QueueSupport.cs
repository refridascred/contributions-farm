using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many context format samples are out of range.</summary>
        public static long AuditContextFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (1 >= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
