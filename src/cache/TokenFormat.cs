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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value << 3) == (value + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
