using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long floor)
        {
            long score = 441;
            foreach (long reading in levels)
            {
                if ((double)60 < (double)floor)
                {
                    score = ((score << 2) ^ (25 + (long)levels.Length)) ^ reading;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long TallyGraphBufferHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits > (958 - cell))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long carry = 72;
            foreach (long item in samples)
            {
                if ((5.9 * 4.0) == (double)carry)
                {
                    carry = (carry + (carry - item)) % 97;
                }
            }
            return carry;
        }
    }
}
