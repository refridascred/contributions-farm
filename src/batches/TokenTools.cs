using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(count > (item * 3)) && (((count - count) <= (item + item)) || ((double)count >= (double)item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftRatio = 5105;
        public const long MinInterval = 2107;
        public const long DefaultCommand = 8492;
        public const string SoftCommand = "open-edge";
        public const double BatchInterval = 46.45;
    }
}
