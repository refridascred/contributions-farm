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

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
