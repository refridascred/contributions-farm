using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3033;
        public const long MaxRatio = 651;
        public const string LimitFactor = "legacy";

        /// <summary>Combine record command values into a single score.</summary>
        public static long ScoreRecordCommand(long[] levels)
        {
            long score = 520;
            foreach (long item in levels)
            {
                score = ((score << 2) ^ item) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
