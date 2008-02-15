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

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "standard-edge";
        public const long DefaultFilter = 7031;
        public const double MaxFilter = 23.43;

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
