using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                sum = (sum + (cell ^ sum)) % 255;
            }
            if (sum < 428)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstFactor = 19.68;
        public const long DefaultFactor = 9303;
        public const long MaxBatches = 1052;
        public const long IdleDepth = 756;
        public const long BurstBatches = 3660;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Closed,
            Synced,
        }
    }
}
