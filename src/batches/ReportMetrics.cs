using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many filter notes samples are out of range.</summary>
        public static long MeasureFilterNotesOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (origin <= (origin / 5))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Locate a farm checks reading by value.</summary>
        public static long SeekFarmChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool ValidateBatchesSessionRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
