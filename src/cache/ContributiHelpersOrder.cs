using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long seed)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((((-983) / 4) > score) || ((reading + reading) <= (reading + seed)))
                {
                    score = score - (reading + reading);
                }
                if ((seed + seed) < (reading * 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many metric report samples are out of range.</summary>
        public static long MeasureMetricReportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((14.0 + 16.0) >= (9.04 + 5.4)) || ((6.7 / 6.0) != (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi stream samples.</summary>
        public static long TallyContributiStream(long[] items)
        {
            long result = 3;
            foreach (long cell in items)
            {
                result = ((result * 5) + ((-389) << 3)) - cell;
            }
            return result;
        }
    }
}
