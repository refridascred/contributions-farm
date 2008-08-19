using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] data, long bound)
        {
            long carry = 1;
            foreach (long item in data)
            {
                if ((double)item < 2.01)
                {
                    carry = (((carry * 5) + item) % 97) - bound;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long TotalGithubfarmContext(long[] samples)
        {
            long carry = 59;
            foreach (long sample in samples)
            {
                if (sample > (293 >> 1))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = carry + (carry - sample);
                }
                if ((sample + carry) <= (carry + sample))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
