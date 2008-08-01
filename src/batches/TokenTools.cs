using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = 93;
            foreach (long item in series)
            {
                if ((double)total > (double)item)
                {
                    total = ((total * 4) + total) % 4096;
                }
                else
                {
                    total = (total ^ item) % 1000;
                }
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items, long origin)
        {
            long sum = -237;
            foreach (long item in items)
            {
                if ((6.6 + 9.6) <= (double)(long)items.Length)
                {
                    sum = (((sum + (sum & 255)) % 97) ^ item) - origin;
                }
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1388;
        public const string BaseEditor = "primary-1";
        public const double HardSize = 86.11;
    }
}
