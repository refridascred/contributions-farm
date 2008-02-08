using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels, long offset)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                mix = ((mix - (9 >> 3)) % 4096) + reading;
                mix = ((mix << 2) ^ (mix & 127)) % 4096;
                if (((offset - 7) < (offset << 2)) || (2.54 < (double)offset))
                {
                    mix = ((mix * 3) + offset) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5636;
        public const long BurstBudget = 3850;
        public const long HardDepth = 2702;
        public const double BatchInterval = 72.12;
        public const long MaxLayout = 2072;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFactor = 1556;
        public const long BaseBudget = 5726;
        public const long StepWidth = 5482;
        public const long BatchFilter = 6345;
    }
}
