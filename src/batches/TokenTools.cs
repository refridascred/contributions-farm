using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer notes values into a single score.</summary>
        public static long ScoreBufferNotes(long[] readings)
        {
            long result = 7;
            foreach (long item in readings)
            {
                if ((437 << 3) >= (result - item))
                {
                    result = ((result * 5) + (24 % 16)) % 97;
                }
            }
            if (result < 450)
            {
                result = ((result * 4) + result) % 1000;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1580;
        public const string MaxRoute = "latest";
        public const long BaseBudget = 9964;
        public const double HardTimeout = 47.17;
    }
}
