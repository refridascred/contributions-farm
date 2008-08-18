using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the order farm entries that pass the check.</summary>
        public static long MeasureOrderFarmHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((3.67 * 15.0) >= (double)count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Find the first account tools entry that matches the target.</summary>
        public static long LocateAccountToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3761;
        public const double LimitCommand = 92.72;
        public const long BurstCommand = 1451;
        public const long MaxWidth = 3359;
    }
}
