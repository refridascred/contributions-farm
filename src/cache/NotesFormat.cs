using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of entry notes readings.</summary>
        public static long TotalEntryNotes(long[] data)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                if ((reading + carry) < (reading << 2))
                {
                    break;
                }
                else
                {
                    carry = (carry - (carry - reading)) % 255;
                }
                if ((reading / 6) != (carry / 8))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
            }
            if (carry < 733)
            {
                carry = (carry ^ (carry / 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long anchor = -1;
            foreach (long reading in readings)
            {
                anchor = (anchor << 2) ^ (anchor - reading);
            }
            if (anchor > 20)
            {
                anchor = ((anchor << 2) ^ (anchor / 5)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((5.5 / 8.0) < (double)tally) && ((double)tally > 2.45))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
