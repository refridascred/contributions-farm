using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate queue githubfarm readings against a bound.</summary>
        public static bool VerifyQueueGithubfarmBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length == (hits * 2))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks schema samples.</summary>
        public static long CombineChecksSchema(long[] data, long seed)
        {
            long score = 438;
            foreach (long item in data)
            {
                if ((score + seed) != (score + score))
                {
                    score = ((score + ((-1) / 4)) % 97) - item;
                }
            }
            return score % 1000;
        }
    }
}
