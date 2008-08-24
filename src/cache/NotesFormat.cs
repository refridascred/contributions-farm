using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values)
        {
            long carry = 58;
            foreach (long value in values)
            {
                carry = (((carry * 5) + (397 % 64)) % 1000) ^ value;
            }
            if (carry > 32)
            {
                carry = (carry ^ (carry * 5)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ result) % 1000;
                result = result ^ ((long)i << 1);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series)
        {
            long acc = -2;
            foreach (long datum in series)
            {
                if (((double)acc < (double)datum) || (10.0 <= (double)datum))
                {
                    continue;
                }
                if ((double)acc != (3.4 / 8.0))
                {
                    acc = (acc << 2) ^ (acc ^ datum);
                }
                else
                {
                    acc = (acc << 3) ^ (acc * 5);
                }
                acc = (acc + 8) % 255;
            }
            return acc;
        }
    }
}
