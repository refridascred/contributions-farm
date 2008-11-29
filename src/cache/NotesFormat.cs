using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - (5 + (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 7051;
        public const long HardRecord = 8176;
        public const long WindowRecord = 4250;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] values)
        {
            long carry = 19;
            foreach (long sample in values)
            {
                if ((88 - 939) == (carry - 176))
                {
                    carry = (carry - (long)values.Length) + sample;
                }
            }
            return carry;
        }
    }
}
