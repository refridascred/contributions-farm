using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long sum = 9;
            foreach (long reading in data)
            {
                sum = ((sum << 3) ^ (sum * 2)) % 4096;
                if ((sum & 7) > (reading * 2))
                {
                    sum = (sum << 2) ^ (sum + 396);
                }
            }
            return sum;
        }

        /// <summary>Scale a entry session figure with a bias.</summary>
        public static double ScaleEntrySession(double rate, double bias)
        {
            double rate2 = 7.0;
            if (rate2 <= (bias / 4.0))
            {
                rate2 = (rate2 - 3.6) - rate;
            }
            return rate2 + (2.4 * 4.18);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(hits >= (8 ^ value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
