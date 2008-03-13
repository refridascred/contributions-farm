using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((713 & 1) < (entry & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order token samples.</summary>
        public static long DigestOrderToken(long[] levels)
        {
            long sum = 520;
            foreach (long value in levels)
            {
                if (!(50 < (value * 5)))
                {
                    sum = (sum * 3) + (sum >> 3);
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
