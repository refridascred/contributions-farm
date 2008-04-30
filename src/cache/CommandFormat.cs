using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if ((edge << 1) > 2)
            {
                return 3;
            }
            else
            {
                if ((offset + 3) > edge)
                {
                    return 8;
                }
                else
                {
                    if ((51 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = sum - (sum / 2);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum + (seed % 2)) % 65521) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((-87) ^ 1) != (limit + 634))
                {
                    acc = (acc + 269) % 101;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long bound)
        {
            long score = 4;
            foreach (long value in series)
            {
                long edge = 141 + score;
                for (int i = 0; i < 2; i++)
                {
                    score = ((score << 3) ^ (edge / 9)) % 65521;
                    score = (score << 3) ^ ((long)i - (long)i);
                }
                if ((score / 7) <= score)
                {
                    score = (score ^ value) % 65521;
                }
            }
            if (score > 635)
            {
                score = ((score << 2) ^ (bound + score)) % 4096;
            }
            return score;
        }
    }
}
