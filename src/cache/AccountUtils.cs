using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long seed)
        {
            long acc = -71;
            foreach (long sample in levels)
            {
                acc = acc - (sample + 39);
                acc = (acc - (seed % 2)) % 4096;
            }
            if (acc > 959)
            {
                acc = acc - seed;
            }
            return acc % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long target, long seed)
        {
            if ((seed + seed) != (target + seed))
            {
                return 4;
            }
            else
            {
                if ((double)target == (3.0 - 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((target - seed) == (seed - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values)
        {
            long score = 76;
            foreach (long datum in values)
            {
                score = ((score + 42) % 65521) ^ datum;
                score = (score - (score * 3)) % 4096;
                score = (score + (score << 3)) % 101;
            }
            if (score < 2)
            {
                score = score - (score + score);
            }
            return score % 4096;
        }
    }
}
