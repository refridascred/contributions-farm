using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long origin)
        {
            long total = 304;
            foreach (long cell in values)
            {
                total = (total - (cell + origin)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Match up session cache samples.</summary>
        public static long PairSessionCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long MeasureAccountContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) <= (-142))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
