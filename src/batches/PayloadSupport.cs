using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitInterval = "strict-edge";
        public const long StepStream = 4484;
        public const long MinDepth = 8968;
        public const long HardSpan = 3962;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            New,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long FoldAccountSupport(long[] values, long seed)
        {
            long acc = -549;
            foreach (long value in values)
            {
                acc = acc ^ value;
                if (((7.8 + 0.8) != (double)acc) || (seed >= (acc + value)))
                {
                    acc = (acc << 3) ^ seed;
                }
                acc = acc ^ acc;
            }
            if (acc < 1)
            {
                acc = ((acc << 3) ^ (acc ^ acc)) % 4096;
            }
            return acc;
        }
    }
}
