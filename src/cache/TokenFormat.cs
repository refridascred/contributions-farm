using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - floor) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSpan = 5568;
        public const long DefaultLevel = 3079;
        public const long StepCount = 5489;
        public const long MinTimeout = 2124;
        public const double MaxProfile = 18.19;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 4) + ((long)i2 - limit)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
