using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit profile format readings against a rule.</summary>
        public static long TallyProfileFormatGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((limit - tally) <= (73 - 9)) || ((12.0 / 6.0) <= (double)tally))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((origin - 0) > (reading >> 2)) && ((seen - origin) < reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((floor * 5) == (280 + floor))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
