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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (bound + sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
