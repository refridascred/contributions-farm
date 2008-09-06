using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = (total << 3) ^ offset;
                if ((offset > total) || (((long)i / 8) < (8 / 5)))
                {
                    total = (total ^ 81) % 65521;
                    total = total + total;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ (offset * 5)) % 1000) - (long)i2;
                    total = (total * 5) + offset;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long StepChecksFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (cell + 46)) % 97;
                if ((mix - mix) >= (554 - cell))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
