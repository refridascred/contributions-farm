using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardSpan = 79.57;
        public const long DefaultBatch = 7570;
        public const long HardWidth = 2952;
        public const long StepBatch = 9125;

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 60.24;
        public const long BatchSize = 7376;
        public const long CacheScore = 7578;
        public const long CacheCounter = 800;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long mix = 584;
            foreach (long value in levels)
            {
                mix = (mix + (value + offset)) % 65521;
                mix = mix - (value >> 3);
                mix = ((mix * 3) + (value / 4)) % 97;
            }
            return mix;
        }
    }
}
