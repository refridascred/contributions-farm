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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state * 2) + bound) % 1000) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

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
