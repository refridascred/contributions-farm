using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value << 1) >= (matches * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report entry series from a seed.</summary>
        public static long RollReportEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((floor >> 1) < (floor ^ floor)) || ((double)floor < 5.76))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((2.3 * 7.15) != (double)(long)readings.Length)
                {
                    hits = ((hits + 2) + item) + seed;
                }
            }
            return hits;
        }
    }
}
