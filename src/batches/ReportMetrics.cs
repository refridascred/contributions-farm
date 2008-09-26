using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine route session values into a single score.</summary>
        public static long FoldRouteSession(long[] series, long origin)
        {
            long mark = 465;
            foreach (long value in series)
            {
                mark = ((mark * 5) + origin) % 101;
                if ((9.05 + 7.54) <= (double)mark)
                {
                    break;
                }
                if ((3 - value) < (value << 3))
                {
                    mark = (mark + (origin + mark)) % 101;
                }
                if ((value - origin) > (value << 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((17.0 * 5.99) != (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
