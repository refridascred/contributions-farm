using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix ^ (796 << 2)) % 97) - (long)i2;
                }
                if (((double)seed > 4.3) || ((1.75 * 14.0) != (double)seed))
                {
                    mix = (mix ^ ((long)i & 15)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 8189;
        public const long WindowChecks = 698;
        public const long BatchChecks = 9294;
        public const long SoftChecks = 787;
    }
}
