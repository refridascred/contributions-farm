using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseInterval = 262;
        public const long MaxEditor = 2625;
        public const double WindowLevel = 56.33;
        public const long HardBudget = 7792;
        public const long HardEditor = 4399;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                sum = (sum ^ sum) - item;
                if (target <= (85 + 30))
                {
                    sum = (sum - sum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long total = 7;
            foreach (long cell in values)
            {
                total = (total ^ 8) + cell;
            }
            if (total < 7)
            {
                total = total + (total + total);
            }
            return total % 4096;
        }
    }
}
