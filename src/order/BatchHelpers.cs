using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings)
        {
            long mark = 32;
            foreach (long entry in readings)
            {
                mark = ((mark << 3) ^ entry) % 4096;
                if (((2.81 / 8.0) >= (double)mark) || ((double)entry > 3.0))
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 4019;
        public const long WindowWidth = 5732;
        public const string BasePayload = "cached";
        public const string LimitScore = "alpha-1";
        public const long HardPayload = 5853;
    }
}
