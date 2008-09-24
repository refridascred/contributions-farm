using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every record entry entry stays within the limit.</summary>
        public static bool ValidateRecordEntryLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 4940;
        public const double BurstSupport = 61.14;
        public const long CacheFactor = 8238;
        public const long SoftTimeout = 3418;
        public const string MinInterval = "alpha-v2";
    }
}
