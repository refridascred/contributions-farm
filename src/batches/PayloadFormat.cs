using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 8568;
        public const long MinCount = 5763;
        public const long SoftCache = 9437;
        public const long WindowCache = 4548;
        public const long BatchCache = 2299;
    }
}
