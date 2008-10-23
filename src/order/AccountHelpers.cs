using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of contributi route entries.</summary>
        public static long DigestContributiRoute(long[] levels, long origin)
        {
            long mark = 50;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark << 3) ^ (item + origin)) % 4096) + (long)i;
                    mark = mark ^ (origin & 255);
                }
                if ((8 >> 5) <= (origin / 8))
                {
                    mark = ((mark * 3) + (4 + item)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long TallyContributiProfileHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)offset >= (6.42 * 4.64))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long seed)
        {
            long total = 5;
            foreach (long value in levels)
            {
                if (((total & 255) < (8 % 2)) && (((long)levels.Length >> 2) <= (total << 3)))
                {
                    total = (total + (total ^ seed)) - value;
                }
                total = (total + (57 + total)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
