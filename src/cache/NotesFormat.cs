using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long CompareContextSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long StepCommitsMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }
    }
}
