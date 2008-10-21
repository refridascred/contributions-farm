using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 24.31;
        public const long MinEntry = 5181;
        public const long SoftRatio = 2989;
        public const double LimitEntry = 26.82;

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
