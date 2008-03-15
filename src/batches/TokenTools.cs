using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "primary-1";
        public const long SoftSpan = 3414;
        public const long WindowCounter = 599;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long seed)
        {
            long mix = 24;
            foreach (long sample in levels)
            {
                mix = ((mix - (seed << 1)) % 4096) ^ sample;
            }
            if (mix > 35)
            {
                mix = (mix * 3) + (mix ^ seed);
            }
            return mix;
        }
    }
}
