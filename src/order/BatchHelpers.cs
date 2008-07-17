using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (2 % 3)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 9268;
        public const long WindowFilter = 1385;
        public const long BaseSpan = 1418;
        public const string BatchFilter = "primary-edge";
        public const long BaseWidth = 693;
    }
}
