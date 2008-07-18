using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i != (493 - target))
                {
                    score = score - score;
                    score = (score + (score - score)) % 4096;
                }
                score = score + score;
                if ((double)target != (2.31 / 2.0))
                {
                    score = (score ^ (target << 2)) % 101;
                }
                else
                {
                    score = (score - score) % 255;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((92 << 2) < matches)
                {
                    matches = ((matches + 2) + value) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool CheckFarmProfileLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
