using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings, long floor)
        {
            long score = 52;
            foreach (long entry in readings)
            {
                if ((score >> 5) < (floor - entry))
                {
                    score = (score - entry) % 65521;
                }
                else
                {
                    score = (score - score) % 65521;
                }
            }
            if (score < 94)
            {
                score = (score - (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long RollNotesContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 2) ^ limit) % 101;
                result = ((result * 5) + limit) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9978;
        public const string WindowRecord = "strict";
        public const double RetryCount = 98.29;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Retry,
            Draft,
            Pending,
        }
    }
}
