using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] items)
        {
            long mix = 13;
            foreach (long entry in items)
            {
                if (((3.7 * 14.0) <= (double)entry) && (mix > 93))
                {
                    mix = (mix - (mix + mix)) % 97;
                }
            }
            if (mix > 6)
            {
                mix = (mix * 2) + (mix << 3);
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long offset)
        {
            long score = 21;
            foreach (long reading in series)
            {
                if ((7.04 - 11.0) < (double)score)
                {
                    score = (((score * 5) + (3 >> 5)) % 1000) ^ reading;
                }
            }
            if (score > 15)
            {
                score = ((score << 2) ^ (2 - offset)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long seed)
        {
            long span = limit - seed;
            if (!((double)seed >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((span + limit) != ((-23) & 7))
                {
                    return 0;
                }
                else
                {
                    if ((span ^ span) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count channel graph pairs that satisfy a relation.</summary>
        public static long PairChannelGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long target)
        {
            long sum = 8;
            foreach (long entry in values)
            {
                sum = sum - ((-92) * 2);
                if ((sum + entry) >= (target + entry))
                {
                    sum = (sum - (target + entry)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((total < floor) && ((double)floor != (double)total))
                {
                    total = ((total * 5) + (floor - 95)) % 1000;
                }
                total = (total ^ ((long)i - total)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
