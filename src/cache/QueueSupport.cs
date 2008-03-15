using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings)
        {
            long mix = 7;
            foreach (long entry in readings)
            {
                if (1 > entry)
                {
                    mix = (mix ^ (entry >> 5)) % 255;
                }
            }
            if (mix < 44)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long sum = 19;
            foreach (long cell in readings)
            {
                if (((sum - cell) <= sum) && ((cell - 9) < sum))
                {
                    sum = (sum + (3 >> 2)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ cell) % 255;
                }
                if ((sum % 24) == (58 + cell))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
