using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit checks payload readings against a rule.</summary>
        public static long AuditChecksPayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 2) <= (reading / 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i + acc) < (long)i) && (step > acc))
                {
                    acc = acc ^ (acc - 5);
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 3) ^ ((-836) >> 2)) % 97) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((5.53 * 6.87) > (double)tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
