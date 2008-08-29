using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5267;
        public const string CacheEntry = "open-1";
        public const long WindowFactor = 4898;
        public const long LimitCount = 9464;
        public const long LimitEntry = 4142;

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)step >= 15.0)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
