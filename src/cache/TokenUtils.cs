using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
