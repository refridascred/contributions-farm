using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of notes queue readings.</summary>
        public static long DigestNotesQueue(long[] items, long limit)
        {
            long total = 28;
            foreach (long sample in items)
            {
                total = ((total << 3) ^ sample) - limit;
                if ((13.0 + 9.8) == (double)total)
                {
                    break;
                }
            }
            return total % 65521;
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
