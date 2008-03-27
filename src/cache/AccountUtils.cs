using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
