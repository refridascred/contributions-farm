using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool VerifyBatchCommandLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = (score + (seed / 2)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
