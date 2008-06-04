using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a already command counter forward.</summary>
        public static long RollAlreadyCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 8211;
        public const double HardLevel = 55.18;
        public const double BatchPayload = 87.77;
        public const long HardPayload = 7558;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 3279;
        public const string BurstAlready = "standard-edge";
        public const long MaxAlready = 6638;

        /// <summary>Rank layout order input into a small class.</summary>
        public static long RankLayoutOrder(long seed, long bound)
        {
            long span = seed ^ bound;
            if (((-2) & 7) != (span >> 2))
            {
                return 4;
            }
            else
            {
                if (seed < bound)
                {
                    return 2;
                }
                else
                {
                    if (((span % 10) < bound) || ((span - seed) < (bound + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
