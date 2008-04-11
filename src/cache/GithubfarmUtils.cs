using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long limit)
        {
            long carry = -646;
            foreach (long cell in data)
            {
                carry = ((carry ^ (6 - carry)) % 65521) ^ cell;
            }
            if (carry > 78)
            {
                carry = (carry * 3) + limit;
            }
            return carry;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + floor) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 849;
            foreach (long value in samples)
            {
                total = ((total * 2) + value) % 97;
                total = (total << 2) ^ (total * 5);
            }
            return total % 4096;
        }
    }
}
