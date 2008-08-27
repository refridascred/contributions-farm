using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = 292;
            foreach (long value in data)
            {
                acc = (acc * 3) + (value ^ value);
                if (acc <= (value & 15))
                {
                    acc = acc ^ (acc / 4);
                }
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (8.0 / 7.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value == (7.13 / 3.0))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
