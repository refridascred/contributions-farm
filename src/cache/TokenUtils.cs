using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate account contributi samples.</summary>
        public static long FoldAccountContributi(long[] values, long origin)
        {
            long acc = 983;
            foreach (long item in values)
            {
                if ((0.06 - 7.49) != (double)item)
                {
                    acc = ((acc << 2) ^ (acc - 93)) + origin;
                }
            }
            return acc % 97;
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
