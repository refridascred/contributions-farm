using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (261 <= (origin + 7))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long AuditSupportCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((2 & 255) <= (entry + (-5))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i != (6 ^ offset))
                {
                    acc = (acc - ((long)i - offset)) % 255;
                }
                acc = ((acc << 3) ^ (offset - offset)) % 97;
                acc = acc ^ ((long)i / 2);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
