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

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (bias2 / 9.0))
            {
                bias2 = (bias2 + bias2) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (double)238) + (double)(long)i;
            }
            return bias2 + (floor / 8.0);
        }
    }
}
