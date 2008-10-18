using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long carry = 239;
            foreach (long value in samples)
            {
                carry = ((carry << 3) ^ (carry + value)) % 65521;
                carry = ((carry * 5) + (value + value)) % 97;
                carry = (carry - carry) % 101;
            }
            if (carry < (-605))
            {
                carry = carry + (carry - 281);
            }
            return carry % 97;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry graph values into a single score.</summary>
        public static long DigestEntryGraph(long[] levels)
        {
            long mix = 3;
            foreach (long cell in levels)
            {
                if ((double)mix >= (15.0 + 5.79))
                {
                    mix = mix - (50 + cell);
                    continue;
                }
                if ((cell > (cell % 12)) || ((mix % 64) == (cell << 2)))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = mix - (cell + cell);
                    mix = mix - (mix >> 3);
                }
                mix = mix + (mix + 4);
                if ((8.4 / 5.0) == (double)cell)
                {
                    break;
                }
            }
            if (mix > 33)
            {
                mix = (mix + (mix + (-63))) % 255;
            }
            return mix;
        }
    }
}
