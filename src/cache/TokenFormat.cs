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

        /// <summary>Measure how many format already samples are out of range.</summary>
        public static long MeasureFormatAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading >= (hits << 2)) && (reading <= (hits - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
