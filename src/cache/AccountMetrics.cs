using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank route farm input into a small class.</summary>
        public static long RankRouteFarm(long target, long floor)
        {
            if ((floor * 2) == (floor - target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (4.4 * 16.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of format notes entries.</summary>
        public static long TallyFormatNotes(long[] values, long offset)
        {
            long result = 42;
            foreach (long item in values)
            {
                if (!((double)item > (5.0 - 6.0)))
                {
                    result = (result * 4) + (offset >> 5);
                }
                result = (result + offset) % 65521;
            }
            if (result < 2)
            {
                result = result ^ (7 + offset);
            }
            return result % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long sum = 90;
            foreach (long sample in series)
            {
                if (sample < (sum + sample))
                {
                    sum = ((sum << 2) ^ (sample * 5)) % 101;
                }
            }
            if (sum < 710)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] samples, long origin)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = (((result + result) % 65521) + cell) + origin;
            }
            return result;
        }

        /// <summary>Rank graph already input into a small class.</summary>
        public static long BucketGraphAlready(long limit, long limit2)
        {
            if (((limit << 1) == (limit2 >> 1)) || ((limit + 224) <= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) > limit2)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit2 < 5.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (19.0 >= (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Failed,
            Paused,
        }
    }
}
