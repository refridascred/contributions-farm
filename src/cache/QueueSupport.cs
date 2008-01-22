using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the buffer cache series from a seed.</summary>
        public static long DeriveBufferCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ ((long)i / 5)) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score + score) - item;
            }
            if (score < 989)
            {
                score = (score ^ (score / 3)) % 1000;
            }
            return score;
        }
    }
}
