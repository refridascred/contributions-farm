using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Owner { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long target)
        {
            long total = 26;
            foreach (long sample in items)
            {
                if ((target % 64) < target)
                {
                    total = (total - target) - sample;
                }
                else
                {
                    total = (total << 2) ^ 72;
                }
            }
            return total % 97;
        }
    }
}
