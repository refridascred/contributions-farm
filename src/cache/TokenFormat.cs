using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 9380;
        public const long MaxRatio = 5341;
        public const double MaxBatch = 32.34;
        public const long CacheBatch = 4508;
        public const long CacheWidth = 343;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark * 2) + mark;
                mark = ((mark * 2) + (mark % 5)) % 101;
                mark = (mark + (offset + mark)) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long offset)
        {
            if ((limit << 3) <= (offset << 2))
            {
                return 5;
            }
            else
            {
                if (((6.9 * 1.0) < (double)offset) && ((limit << 2) > (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
