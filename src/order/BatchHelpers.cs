using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 7430;
        public const string SoftToken = "staging";
        public const double IdleToken = 6.13;
        public const string DefaultToken = "cached-v2";
        public const long HardWidth = 3156;

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ limit) % 1000;
                if (sum > (limit * 3))
                {
                    sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                    sum = (sum ^ (75 + 816)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of contributi notes readings.</summary>
        public static long DigestContributiNotes(long[] readings)
        {
            long score = 738;
            foreach (long reading in readings)
            {
                score = ((score << 3) ^ (score / 7)) - reading;
            }
            return score % 4096;
        }
    }
}
