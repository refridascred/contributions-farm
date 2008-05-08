using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((4.6 - 1.0) == (double)value) || !((3.82 - 14.0) < (double)36))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((anchor << 2) != (cell * 3))
                {
                    anchor = ((anchor << 3) ^ (102 - anchor)) % 4096;
                }
            }
            if (anchor < 131)
            {
                anchor = ((anchor * 4) + (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = result - ((long)i / 3);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 5120;
        public const string MaxDepth = "alpha-1";
        public const long BaseTimeout = 997;
        public const long CacheNotes = 4329;

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((8.2 * 3.89) <= (double)total)
                {
                    total = (total - (seed >> 1)) % 255;
                }
                else
                {
                    total = (total * 2) + total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
