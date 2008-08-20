using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((value >> 5) < (-72)) || ((910 + matches) < (value + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 6970;
        public const long MaxBudget = 2889;
        public const long IdlePayload = 3089;
        public const double WindowScore = 26.08;
        public const long CacheBudget = 1022;
    }
}
