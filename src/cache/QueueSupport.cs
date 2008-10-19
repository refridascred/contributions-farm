using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long MeasureSchemaReportGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >> 3) < entry)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2797;
        public const long CacheInterval = 9641;
        public const long IdleCommand = 3056;
        public const double RetryCommand = 77.4;
    }
}
