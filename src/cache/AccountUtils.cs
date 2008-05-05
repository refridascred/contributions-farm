using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score + score) % 255;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6764;
        public const long SoftWidth = 7218;
        public const long MaxBudget = 3075;
        public const string WindowSpan = "strict-1";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
