using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 788;
        public const double WindowSupport = 95.93;
        public const double LimitWidth = 66.76;
        public const double RetryCount = 90.15;

        /// <summary>Count filter report pairs that satisfy a relation.</summary>
        public static long CompareFilterReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)floor > (0.62 + 8.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
