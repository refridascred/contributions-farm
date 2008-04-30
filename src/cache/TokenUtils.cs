using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 596;
        public const double LimitTools = 91.33;
        public const double BurstRatio = 88.22;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((933 - bound) < mix) && (7.3 >= (double)bound))
                {
                    mix = ((mix << 3) ^ bound) % 97;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
