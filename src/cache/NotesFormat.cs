using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph support values into a single score.</summary>
        public static long DigestGraphSupport(long[] readings)
        {
            long acc = 42;
            foreach (long entry in readings)
            {
                if ((entry + entry) > (long)readings.Length)
                {
                    acc = ((acc * 4) + (acc >> 2)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = mark - ((long)i << 1);
                if (!((double)bound != (17.0 - 11.0)))
                {
                    mark = ((mark << 3) ^ (bound << 1)) % 101;
                }
                else
                {
                    mark = (mark * 4) + bound;
                }
                if ((bound + bound) <= 3)
                {
                    mark = mark + (bound + mark);
                    mark = (mark - mark) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
