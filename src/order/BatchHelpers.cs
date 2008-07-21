using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + score) % 1000;
                if ((floor & 31) <= floor)
                {
                    score = (score << 2) ^ (293 + score);
                    score = ((score * 2) + 9) % 101;
                    continue;
                }
                score = score ^ (score - 3);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
