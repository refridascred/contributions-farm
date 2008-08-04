using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 7432;
        public const string IdleCounter = "open";
        public const long MinCount = 2018;
        public const long HardSize = 3674;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state << 3) ^ (target ^ state)) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheDepth = 1545;
        public const long SoftSchema = 6990;
        public const string MaxSchema = "staging-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4271;
        public const double CacheWindow = 67.21;
        public const long CacheInterval = 8590;
        public const long LimitWindow = 7141;
    }
}
