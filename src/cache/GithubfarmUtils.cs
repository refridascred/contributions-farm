using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 3) ^ (carry - limit);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches >= (20.0 + 15.0))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = -269;
            foreach (long reading in data)
            {
                acc = (acc + (reading ^ reading)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
