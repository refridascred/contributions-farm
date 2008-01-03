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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long result = 702;
            foreach (long value in data)
            {
                if ((double)result <= 7.41)
                {
                    result = (result - (value - 60)) - step;
                }
            }
            if (result < (-9))
            {
                result = (result - (38 - result)) % 97;
            }
            return result;
        }
    }
}
