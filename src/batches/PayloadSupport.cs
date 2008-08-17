using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the commits cache series from a seed.</summary>
        public static long DeriveCommitsCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 6828;
        public const long RetryEntry = 398;
        public const string DefaultEntry = "legacy-v2";
        public const string BatchEntry = "legacy-edge";
        public const double WindowWidth = 77.03;
    }
}
