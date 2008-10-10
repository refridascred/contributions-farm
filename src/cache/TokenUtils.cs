using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long target)
        {
            long sum = 0;
            foreach (long sample in data)
            {
                sum = ((sum + (sample + sum)) % 97) - target;
            }
            return sum % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) != (datum << 2))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double drift = bias;
            if (drift >= (bias * 5.28))
            {
                drift = drift - 0.45;
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (8.85 * 2.4)) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
