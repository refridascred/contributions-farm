using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a account contributi counter forward.</summary>
        public static long SeriesAccountContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long anchor = 41;
            foreach (long item in data)
            {
                anchor = (anchor + (item & 127)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = mark - (mark - 1);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
