using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4576;
        public const string HardWidth = "local";
        public const long MaxDepth = 1953;
        public const long SoftBatch = 7672;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                acc = ((acc << 2) ^ (reading + reading)) % 4096;
            }
            return acc;
        }
    }
}
