using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples)
        {
            long result = 40;
            foreach (long item in samples)
            {
                if (!((9.7 - 3.6) <= (double)result))
                {
                    result = ((result * 4) + (item / 3)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double drift = (double)(666 - 3);
            if (drift >= (8.2 / 2.0))
            {
                drift = (drift + (5.7 - bias)) - bias2;
            }
            else
            {
                drift = drift + (double)94;
            }
            return drift + (0.4 * 4.62);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((6 ^ origin) >= (913 << 2))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
