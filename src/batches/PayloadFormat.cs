using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((((seen - value) < value) && ((seen - seen) == (191 + value))) || ((0.69 * 8.7) > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 4916;
        public const string SoftSize = "alpha";
        public const double DefaultInterval = 90.46;
        public const long BurstMetrics = 4517;
        public const string BatchSpan = "stable";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count + entry) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
