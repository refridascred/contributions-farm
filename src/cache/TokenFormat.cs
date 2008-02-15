using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if ((676 & 255) > (state % 24))
                {
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    state = ((state + value) % 255) + (long)i;
                }
                if (((value - value) <= (-18)) && ((value << 1) > ((long)samples.Length % 12)))
                {
                    state = state - (state + offset);
                }
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series)
        {
            long result = 2;
            foreach (long datum in series)
            {
                result = (result ^ datum) % 101;
                if (!(4.42 < (double)datum))
                {
                    result = (result - (datum - datum)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long origin)
        {
            if (!((floor + origin) > (floor >> 5)))
            {
                return 5;
            }
            else
            {
                if (origin >= floor)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
