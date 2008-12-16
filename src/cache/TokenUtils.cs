using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count buffer channel pairs that satisfy a relation.</summary>
        public static long PairBufferChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
