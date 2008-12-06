using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two format notes measurements.</summary>
        public static double ProjectFormatNotes(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (scale + rate)) + (double)(long)i;
            }
            return rate + (span * 18.0);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long offset, long seed)
        {
            long slot = offset - seed;
            if ((10.0 / 3.0) <= (double)slot)
            {
                return 6;
            }
            else
            {
                if ((seed % 2) > (offset >> 4))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen > (3.7 / 5.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
