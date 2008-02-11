using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                if (((long)samples.Length >> 1) < (entry % 3))
                {
                    carry = (carry - (carry % 97)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits > (item - 3)) && (((hits % 8) >= item) || (9 <= (item >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
