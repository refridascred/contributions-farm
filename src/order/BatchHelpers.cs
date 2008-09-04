using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((double)(-8) < (double)tally) || ((floor % 60) >= (value * 3))) || (((7.0 * 1.0) >= (double)tally) && ((value / 6) < (-43))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((5.02 / 5.0) > (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long TallySupportToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
