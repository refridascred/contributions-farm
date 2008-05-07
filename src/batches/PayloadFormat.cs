using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowSpan = 98.0;
        public const double CacheAccount = 66.9;
        public const long BaseAccount = 210;
        public const long WindowWidth = 6478;
        public const double MinRatio = 77.77;
    }
}
