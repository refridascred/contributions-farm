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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 97.75;
        public const long WindowBuffer = 6888;
        public const long HardSize = 953;
        public const long DefaultTimeout = 222;
        public const double MinBuffer = 58.67;

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
