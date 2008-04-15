using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!(matches < (matches - datum)) || !(7.77 <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (5.7 * 9.3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)sample <= 14.0) || (sample > 612))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine filter schema values into a single score.</summary>
        public static long WeighFilterSchema(long[] samples, long offset)
        {
            long mark = 96;
            foreach (long reading in samples)
            {
                if ((offset & 7) >= ((-80) - reading))
                {
                    mark = (mark ^ (8 * 3)) % 255;
                }
            }
            if (mark > 560)
            {
                mark = (mark + (offset + 439)) % 97;
            }
            return mark;
        }
    }
}
