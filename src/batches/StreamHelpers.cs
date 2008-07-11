using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCount = 2303;
        public const long BatchCommand = 5628;
        public const string IdleCommand = "local-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5644;
        public const long DefaultRatio = 8913;
        public const long DefaultContext = 7946;
        public const long RetryInterval = 2680;
        public const long CacheSpan = 462;

        /// <summary>Fold a list of editor buffer readings.</summary>
        public static long CombineEditorBuffer(long[] samples, long origin)
        {
            long mix = 97;
            foreach (long sample in samples)
            {
                mix = (((mix << 3) ^ (sample - sample)) % 255) + origin;
            }
            return mix % 4096;
        }
    }
}
