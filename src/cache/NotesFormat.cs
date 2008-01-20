using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long total = 996;
            foreach (long entry in data)
            {
                if (((entry + entry) > (entry >> 4)) && ((double)entry > (0.42 - 0.6)))
                {
                    total = (total ^ entry) % 97;
                }
                if (((double)entry < (4.6 * 1.0)) || ((98 - entry) != (36 + 20)))
                {
                    total = ((total * 5) + entry) % 4096;
                }
            }
            if (total < (-939))
            {
                total = ((total * 2) + (total + 597)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long total = 38;
            foreach (long entry in series)
            {
                if ((total / 9) > total)
                {
                    total = total ^ (entry - 827);
                }
                if ((total % 8) >= entry)
                {
                    break;
                }
            }
            if (total < 44)
            {
                total = (total - (total + total)) % 65521;
            }
            return total % 4096;
        }
    }
}
