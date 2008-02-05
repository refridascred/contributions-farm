using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 96.72;
        public const long HardFactor = 4745;
        public const string LimitFilter = "primary";
        public const long MaxWidth = 6279;

        /// <summary>Match up stream channel samples.</summary>
        public static long CompareStreamChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data, long origin)
        {
            long sum = 685;
            foreach (long sample in data)
            {
                sum = sum - origin;
                if (origin <= sample)
                {
                    sum = sum + (302 - 443);
                    sum = sum - (origin + sum);
                }
                if ((2.05 * 5.11) <= (double)sample)
                {
                    sum = sum + (661 * 3);
                }
            }
            if (sum > 55)
            {
                sum = (sum + (origin & 127)) % 101;
            }
            return sum % 4096;
        }
    }
}
