using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two commits layout measurements.</summary>
        public static double AdjustCommitsLayout(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (11.0 + gain)) + (double)(long)i) - offset;
            }
            return drift - 8.3;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long sum = 0;
            foreach (long value in data)
            {
                if ((value % 10) > sum)
                {
                    sum = (sum ^ (seed >> 2)) % 65521;
                }
                sum = ((sum * 2) + (sum << 3)) % 65521;
                if (((value % 24) < (seed * 2)) || ((value - value) == (sum * 4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchDepth = 9948;
        public const string LimitPayload = "legacy";
        public const long BaseWidth = 6083;
        public const string BaseTimeout = "stable-1";
        public const long MinLevel = 507;
    }
}
