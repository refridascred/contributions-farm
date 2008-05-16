using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items)
        {
            long mark = 867;
            foreach (long cell in items)
            {
                mark = ((mark + ((-516) ^ 0)) % 1000) + cell;
            }
            return mark % 4096;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ ((long)i * 5);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
