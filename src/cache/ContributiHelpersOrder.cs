using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (444 < (148 + seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + hits) != (119 % 100))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
            }
            return hits;
        }
    }
}
