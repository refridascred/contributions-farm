using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2979;
        public const long IdleFormat = 8104;
        public const long SoftDepth = 8401;
        public const long WindowScore = 9124;
        public const string WindowFormat = "primary";

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels, long target)
        {
            long acc = 30;
            foreach (long value in levels)
            {
                if ((acc + 8) >= (target % 64))
                {
                    acc = ((acc ^ ((-1) & 255)) % 1000) - value;
                }
            }
            if (acc > 0)
            {
                acc = acc + 2;
            }
            return acc;
        }
    }
}
