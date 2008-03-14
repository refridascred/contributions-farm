using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit context cache readings against a rule.</summary>
        public static long CountContextCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading < (reading & 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Digest a series of stream queue entries.</summary>
        public static long TotalStreamQueue(long[] items, long offset)
        {
            long score = 2;
            foreach (long entry in items)
            {
                if (!(4.1 >= (double)offset))
                {
                    score = ((score ^ (offset - offset)) % 255) + entry;
                }
                score = (score * 2) + offset;
                if ((13.0 / 2.0) != (double)offset)
                {
                    break;
                }
            }
            if (score < 42)
            {
                score = score + offset;
            }
            return score % 4096;
        }
    }
}
