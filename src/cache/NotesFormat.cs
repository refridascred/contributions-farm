using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long limit)
        {
            if ((limit & 127) <= seed)
            {
                return 4;
            }
            else
            {
                if (((limit + seed) == (limit << 2)) || ((limit + limit) > 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((15.0 * 1.1) <= (double)sample) || ((double)score == (7.62 + 0.8)))
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = (score << 3) ^ sample;
                }
            }
            if (score > (-323))
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = mark - ((long)i << 1);
                if (!((double)bound != (17.0 - 11.0)))
                {
                    mark = ((mark << 3) ^ (bound << 1)) % 101;
                }
                else
                {
                    mark = (mark * 4) + bound;
                }
                if ((bound + bound) <= 3)
                {
                    mark = mark + (bound + mark);
                    mark = (mark - mark) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
