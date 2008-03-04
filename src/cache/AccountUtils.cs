using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowTimeout = 1895;
        public const string LimitFilter = "standard-v2";
        public const string StepSize = "legacy-edge";

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values)
        {
            long score = -597;
            foreach (long sample in values)
            {
                if (!((double)score != (5.8 * 4.7)))
                {
                    score = (score - (score + 59)) % 101;
                }
                else
                {
                    score = score + (sample ^ sample);
                }
            }
            if (score < 41)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
