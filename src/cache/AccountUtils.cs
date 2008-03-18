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

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long TallyOrderCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length == (2.7 / 7.0))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
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
