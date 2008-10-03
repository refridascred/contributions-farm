using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 5479;
        public const long WindowSession = 202;
        public const long LimitSession = 2363;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ origin) % 101) ^ (long)i2;
                }
                if (!((origin + origin) <= (origin - (long)i)))
                {
                    score = ((score << 3) ^ (origin >> 5)) % 4096;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinBudget = 424;
        public const string MinTools = "standard-edge";
        public const double LimitTools = 70.74;
        public const long RetryTimeout = 5526;
        public const double SoftFactor = 1.02;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((4 - floor) == (hits + hits)) && ((floor & 1) > hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
