using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a entry contributi reading by value.</summary>
        public static long LookupEntryContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitScore = "stable-1";
        public const long MaxEntry = 4582;
        public const string HardTimeout = "fallback-1";
        public const string DefaultEntry = "standard-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long mark = 301;
            foreach (long sample in readings)
            {
                mark = mark - (sample & 3);
                mark = ((mark << 3) ^ 18) % 4096;
                if (sample < (mark + sample))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
