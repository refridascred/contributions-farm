using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long sum = 29;
            foreach (long cell in series)
            {
                if ((sum >= (sum - offset)) || ((981 + cell) < cell))
                {
                    sum = sum + (cell << 2);
                }
            }
            if (sum < 2)
            {
                sum = sum ^ (offset - sum);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (28 - seed)) % 255;
                if ((seed % 64) <= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 2) < 52)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
