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

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultTimeout = 77.17;
        public const long SoftRecord = 9833;
        public const long StepRecord = 2634;

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
