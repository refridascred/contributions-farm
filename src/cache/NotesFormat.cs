using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items, long origin)
        {
            long result = 180;
            foreach (long value in items)
            {
                if ((origin >= value) || ((19.0 * 18.0) == (double)origin))
                {
                    result = (result << 3) ^ (value + origin);
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Draft,
            Failed,
            Active,
        }
    }
}
