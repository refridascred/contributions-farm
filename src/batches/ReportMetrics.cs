using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                acc = ((acc * 2) + (item + item)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many profile report samples are out of range.</summary>
        public static long MeasureProfileReportHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((36 & 3) < (tally ^ 76))
                {
                    tally = ((tally + 3) - cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long limit)
        {
            if (step < (step + 534))
            {
                return 0;
            }
            else
            {
                if ((step << 1) < limit)
                {
                    return 7;
                }
                else
                {
                    if (((double)limit == (2.7 / 8.0)) || ((double)limit >= (3.9 + 5.87)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
