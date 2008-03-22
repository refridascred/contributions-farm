using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (94 <= tally)
                {
                    tally = ((tally + 2) + value) - offset;
                }
            }
            return tally;
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
