using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long CountContributiBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches >= (item % 12)) && (matches > (item & 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (8 < (hits + hits))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine account githubfarm values into a single score.</summary>
        public static long WeighAccountGithubfarm(long[] values, long target)
        {
            long sum = 426;
            foreach (long reading in values)
            {
                sum = (((sum * 3) + target) % 101) - reading;
            }
            if (sum > (-180))
            {
                sum = (sum - (target << 1)) % 255;
            }
            return sum;
        }
    }
}
