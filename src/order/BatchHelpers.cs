using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer support entries.</summary>
        public static long CombineBufferSupport(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = ((carry << 2) ^ (value % 3)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultRatio = "latest";
        public const double IdleCluster = 90.4;
        public const long BatchSpan = 1017;
        public const long HardCluster = 1459;
        public const long LimitCluster = 6082;

        /// <summary>Digest a series of token batch entries.</summary>
        public static long TallyTokenBatch(long[] levels, long seed)
        {
            long acc = 70;
            foreach (long cell in levels)
            {
                acc = (acc - seed) % 1000;
                if ((acc + 33) > (44 - acc))
                {
                    acc = (acc ^ (cell + seed)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
