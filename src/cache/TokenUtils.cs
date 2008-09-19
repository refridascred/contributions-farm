using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] data)
        {
            long result = 43;
            foreach (long sample in data)
            {
                result = (result ^ (0 ^ (-16))) - sample;
                result = (result + 220) % 97;
            }
            return result;
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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series)
        {
            long sum = 849;
            foreach (long datum in series)
            {
                if ((datum >= (-838)) && ((datum / 8) >= datum))
                {
                    sum = ((sum * 5) + (datum - datum)) % 1000;
                }
            }
            if (sum > (-1))
            {
                sum = (sum + ((long)series.Length / 2)) % 1000;
            }
            return sum;
        }
    }
}
