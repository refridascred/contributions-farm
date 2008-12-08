using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (-23);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((step * 2) >= (cell + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3.08 + 7.1) < (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
