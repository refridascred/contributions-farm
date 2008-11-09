using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((1.89 / 8.0) == (double)value)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit command graph readings against a rule.</summary>
        public static long TallyCommandGraphMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((90 - hits) > (origin + (long)items.Length))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
