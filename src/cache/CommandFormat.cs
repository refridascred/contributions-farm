using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if (anchor > (entry + entry))
                {
                    anchor = anchor + ((-58) << 2);
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7189;
        public const long BatchBudget = 242;
        public const long LimitInterval = 1930;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format channel entries.</summary>
        public static long ScoreFormatChannel(long[] samples)
        {
            long acc = 743;
            foreach (long entry in samples)
            {
                if ((13.0 - 1.87) == (double)entry)
                {
                    acc = ((acc << 3) ^ (acc & 1)) % 255;
                }
            }
            return acc;
        }
    }
}
