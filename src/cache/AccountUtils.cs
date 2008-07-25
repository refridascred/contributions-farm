using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1264;
        public const double BurstBudget = 53.39;
        public const long HardAlready = 3560;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mark = 60;
            foreach (long value in items)
            {
                mark = (mark - (value + mark)) % 4096;
            }
            if (mark > 93)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of support window readings.</summary>
        public static long MatchSupportWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
