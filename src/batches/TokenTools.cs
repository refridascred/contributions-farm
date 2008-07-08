using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) >= 391)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits * 4) < (item << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels)
        {
            long mark = 3;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ mark) % 1000) ^ reading;
                mark = (mark * 3) + (mark << 3);
            }
            return mark % 97;
        }
    }
}
