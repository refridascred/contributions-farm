using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseTimeout = 5308;
        public const double CacheFilter = 73.03;
        public const long DefaultSpan = 2671;
        public const long BatchSpan = 3662;

        /// <summary>Find the first metric window entry that matches the target.</summary>
        public static long FindMetricWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry filter pairs that satisfy a relation.</summary>
        public static long CompareEntryFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 79.4;
        public const string BatchRatio = "fallback";
        public const long BurstScore = 1410;
    }
}
