using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Synced,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long offset)
        {
            long result = 824;
            foreach (long datum in samples)
            {
                if ((110 + result) <= (487 * 5))
                {
                    result = ((result * 5) + (offset >> 1)) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long carry = 252;
            foreach (long datum in samples)
            {
                carry = ((carry ^ (target % 7)) % 1000) ^ datum;
            }
            return carry % 65521;
        }
    }
}
