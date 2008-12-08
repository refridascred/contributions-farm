using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the account counter series from a seed.</summary>
        public static long StepAccountCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long carry = 13;
            foreach (long item in series)
            {
                if ((95 << 2) < carry)
                {
                    carry = ((carry - ((-1) ^ carry)) % 4096) - item;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry > 46)
            {
                carry = (carry - (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset - 34) >= (3 & 127))
            {
                return 6;
            }
            else
            {
                if (((96 - offset) > 70) && ((double)offset >= (2.5 + 11.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
