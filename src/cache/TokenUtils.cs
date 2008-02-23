using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Done,
            Active,
            Synced,
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long DigestFilterStream(long[] items, long offset)
        {
            long mix = 66;
            foreach (long datum in items)
            {
                if ((offset * 4) < datum)
                {
                    mix = mix + (26 >> 4);
                }
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepLevel = 93.55;
        public const string StepStats = "fallback";
        public const double SoftStats = 40.48;
        public const double DefaultStats = 5.22;
        public const long CacheStats = 3585;
    }
}
