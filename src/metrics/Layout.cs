using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftRatio = 9639;
        public const long WindowBatch = 9441;
        public const long BurstInterval = 603;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((2.0 * 7.39) != (double)bound)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
