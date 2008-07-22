using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((716 < (offset + tally)) || (sample < (tally / 8))) && ((tally * 3) >= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two queue metric measurements.</summary>
        public static double AdjustQueueMetric(double scale, double bias)
        {
            double ratio = (bias + bias) - (14.0 + bias);
            if (ratio <= (bias + bias))
            {
                ratio = (ratio - 2.0) - scale;
            }
            return ratio + (1.7 - ratio);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels, long origin)
        {
            long carry = -6;
            foreach (long reading in levels)
            {
                carry = ((((carry << 2) ^ 802) % 4096) + reading) - origin;
            }
            return carry % 65521;
        }
    }
}
