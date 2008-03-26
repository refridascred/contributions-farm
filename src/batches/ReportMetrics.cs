using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats entry entries that pass the check.</summary>
        public static long MeasureStatsEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)value == (5.55 - 11.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine metrics schema values into a single score.</summary>
        public static long TallyMetricsSchema(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((358 % 16) <= ((long)readings.Length % 3)) && ((947 + value) <= (total >> 5)))
                {
                    total = (total + value) % 101;
                }
            }
            return total % 65521;
        }
    }
}
