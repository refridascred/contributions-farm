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

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
