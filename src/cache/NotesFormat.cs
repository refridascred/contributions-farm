using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command graph readings against a rule.</summary>
        public static long MeasureCommandGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((69 + reading) == (reading % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Paused,
            Done,
            Active,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
