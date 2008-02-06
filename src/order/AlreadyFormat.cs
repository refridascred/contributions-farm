using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Active,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 8185;
        public const long LimitCache = 8472;
        public const long SoftInterval = 3108;
        public const long BaseCache = 8850;
        public const long BurstFactor = 843;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 73;
            foreach (long cell in items)
            {
                if (!((cell - acc) >= (long)items.Length))
                {
                    acc = (acc - (cell & 31)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
