using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((5.8 + 3.99) >= (double)floor)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "stable-1";
        public const long MaxWidth = 3017;
        public const long RetryRecord = 291;

        /// <summary>Locate a support channel reading by value.</summary>
        public static long FindSupportChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6064;
        public const long WindowRoute = 8629;
        public const long RetryRoute = 1540;
        public const long BurstRoute = 9736;
        public const double BaseScore = 11.37;
    }
}
