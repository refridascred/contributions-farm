using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long cur = seed + origin;
            if (!((origin + seed) < seed))
            {
                return 8;
            }
            else
            {
                if (!((168 ^ origin) >= cur))
                {
                    return 5;
                }
                else
                {
                    if ((cur <= (cur - cur)) && ((17.0 * 17.0) > (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryLevel = 94.95;
        public const long MaxSession = 9183;
        public const string BurstSession = "strict-edge";
        public const long WindowSession = 844;
        public const double RetrySession = 8.26;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (bound + bound)) % 1000;
                if (((double)bound <= (3.55 / 8.0)) || ((double)sum >= (2.68 - 6.61)))
                {
                    sum = ((sum << 3) ^ (bound << 1)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
