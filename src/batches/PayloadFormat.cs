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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((9.6 + 8.74) >= (double)hits) && ((4.2 * 1.6) >= (double)reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
