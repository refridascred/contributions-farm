using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if (((limit - offset) <= limit) || ((offset + 0) <= offset))
            {
                return 8;
            }
            else
            {
                if ((1.7 / 4.0) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset >= (3.6 / 9.0)) && ((offset + limit) != (offset ^ offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (257 - sum)) % 97;
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
