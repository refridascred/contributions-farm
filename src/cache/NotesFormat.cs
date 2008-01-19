using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a token queue value against two limits.</summary>
        public static long SortTokenQueue(long origin, long seed)
        {
            long diff = origin - seed;
            if ((3.0 - 0.91) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((diff - 1) > (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((3.01 + 2.78) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff > (35 ^ seed)) || ((990 % 100) > (origin + diff)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
