using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next entry schema value.</summary>
        public static double ScaleEntrySchema(double rate, double offset)
        {
            double weight = offset * 9.5;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)(long)i) - rate;
            }
            return weight + weight;
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long CountBufferPayloadHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((20.0 * 7.87) > (double)limit) || (limit >= (limit + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((target * 4) < (value << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
