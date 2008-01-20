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

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool VerifyWindowSessionLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
