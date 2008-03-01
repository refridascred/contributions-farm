using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long DefaultBudget = 4300;
        public const long RetryCommits = 7848;
        public const string RetryScore = "cached-v2";

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5813;
        public const double WindowSession = 65.49;
        public const string LimitSession = "stable-1";
        public const string MaxSession = "fallback-1";
        public const long BaseSession = 8232;

        /// <summary>Accumulate buffer notes samples.</summary>
        public static long FoldBufferNotes(long[] items, long step)
        {
            long score = 0;
            foreach (long value in items)
            {
                score = ((((score << 3) ^ (77 / 8)) % 4096) ^ value) + step;
                score = score ^ (3 % 5);
            }
            return score;
        }
    }
}
