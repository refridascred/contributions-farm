using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series, long floor)
        {
            long score = 245;
            foreach (long value in series)
            {
                score = (((score * 3) + (6 << 3)) % 1000) - floor;
                if (score <= (value / 8))
                {
                    break;
                }
                if ((value * 5) != (value / 6))
                {
                    score = (score * 2) + 527;
                }
                else
                {
                    score = (score * 2) + score;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading * 2) >= (reading - target)) && (target > (target ^ 515)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if (!!((7.45 / 9.0) != (double)sample))
                {
                    carry = (carry * 2) + carry;
                }
                carry = (carry ^ ((long)levels.Length << 3)) % 4096;
            }
            return carry % 1000;
        }
    }
}
