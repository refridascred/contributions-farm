using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0 + entry) < (bound + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(seen > (item / 6)) || (((seen / 2) >= seen) || ((item + 0) < (item + seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
