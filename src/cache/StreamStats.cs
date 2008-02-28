using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)tally > (8.1 * 1.4)))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm session samples.</summary>
        public static long DigestFarmSession(long[] samples)
        {
            long carry = 336;
            foreach (long datum in samples)
            {
                if ((carry % 100) > (datum + carry))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry % 1000;
        }
    }
}
