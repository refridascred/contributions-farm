using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleTimeout = 9361;
        public const long MaxSpan = 3642;
        public const long SoftChecks = 7490;
        public const double HardChecks = 9.23;

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
