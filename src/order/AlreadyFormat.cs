using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 6564;
        public const long IdleQueue = 801;
        public const string BatchLevel = "open-v2";
        public const long BatchQueue = 9660;
        public const long BatchScore = 13;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheInterval = 74.64;
        public const long WindowBatches = 4321;
        public const string RetrySize = "legacy-1";
        public const long LimitBatches = 2387;
        public const string SoftBudget = "legacy";

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                sum = ((sum ^ (sum + sum)) % 65521) - offset;
                if ((datum + datum) <= (156 & 255))
                {
                    sum = (sum << 3) ^ (datum % 97);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long sum = 99;
            foreach (long datum in series)
            {
                sum = (((sum - (sum >> 2)) % 255) + datum) + floor;
            }
            return sum;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
