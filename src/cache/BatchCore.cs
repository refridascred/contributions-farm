using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema window readings against a rule.</summary>
        public static long CountSchemaWindowOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((26 ^ limit) <= ((long)readings.Length / 4))
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "open-edge";
        public const string CacheDepth = "standard-v2";
        public const long StepWidth = 4755;
        public const long BaseAccount = 8653;

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 13.49;
        public const string DefaultSize = "legacy-edge";
        public const long SoftSession = 3272;
    }
}
