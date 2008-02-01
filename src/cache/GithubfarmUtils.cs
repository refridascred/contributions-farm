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

        /// <summary>Fold a list of profile support readings.</summary>
        public static long FoldProfileSupport(long[] items)
        {
            long total = 0;
            foreach (long datum in items)
            {
                if ((datum >> 1) > (5 << 2))
                {
                    total = (total * 3) + (datum << 3);
                }
            }
            return total % 65521;
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
