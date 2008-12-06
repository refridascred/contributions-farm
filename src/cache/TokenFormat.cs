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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long origin)
        {
            if ((limit ^ origin) != (origin & 63))
            {
                return 1;
            }
            else
            {
                if ((origin ^ origin) >= origin)
                {
                    return 3;
                }
                else
                {
                    return 6;
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
