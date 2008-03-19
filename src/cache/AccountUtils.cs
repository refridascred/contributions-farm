using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryDepth = 5017;
        public const double BaseOrder = 48.18;
        public const long BatchLevel = 5939;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((3.7 / 5.0) < (double)matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile batches reading by value.</summary>
        public static long LocateProfileBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
