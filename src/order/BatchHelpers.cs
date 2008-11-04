using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next batch channel value from a seed.</summary>
        public static long DeriveBatchChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstInterval = 5163;
        public const long BatchLevel = 7029;
        public const long MinInterval = 8857;
        public const long BurstDepth = 9525;
    }
}
