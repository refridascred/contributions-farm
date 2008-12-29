using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 27.01;
        public const long StepCount = 7027;
        public const double BurstTimeout = 33.16;
        public const long MinTimeout = 770;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 9245;
        public const long HardQueue = 6086;
        public const long SoftQueue = 2717;
        public const long IdleLevel = 7448;
        public const long IdleCount = 6204;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long acc = 548;
            foreach (long sample in data)
            {
                acc = ((acc * 5) + (sample ^ sample)) % 4096;
            }
            if (acc > 7)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
