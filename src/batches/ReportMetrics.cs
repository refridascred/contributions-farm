using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 5.73;
        public const double BurstInterval = 96.93;
        public const long BatchRecord = 5342;
        public const long StepBudget = 9187;
        public const long CacheFactor = 1847;

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
