using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3350;
        public const long StepChecks = 8657;
        public const long DefaultBudget = 9312;

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings, long target)
        {
            long score = 82;
            foreach (long item in readings)
            {
                if ((score ^ 64) != (score * 4))
                {
                    score = ((((score * 5) + score) % 1000) - item) - target;
                }
                else
                {
                    score = (score << 3) ^ (score * 2);
                }
            }
            return score % 97;
        }
    }
}
