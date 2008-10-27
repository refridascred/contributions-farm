using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ limit) % 1000;
                if (sum > (limit * 3))
                {
                    sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                    sum = (sum ^ (75 + 816)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of contributi notes readings.</summary>
        public static long DigestContributiNotes(long[] readings)
        {
            long score = 738;
            foreach (long reading in readings)
            {
                score = ((score << 3) ^ (score / 7)) - reading;
            }
            return score % 4096;
        }
    }
}
