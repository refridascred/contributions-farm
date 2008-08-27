using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter farm values into a single score.</summary>
        public static long CombineCounterFarm(long[] series, long bound)
        {
            long acc = 59;
            foreach (long datum in series)
            {
                if (!((double)bound < (2.8 - 9.5)))
                {
                    acc = (acc + (bound << 1)) + datum;
                }
            }
            if (acc > (-2))
            {
                acc = ((acc << 3) ^ (acc - bound)) % 101;
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
