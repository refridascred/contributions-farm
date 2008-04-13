using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Done,
            Retry,
            Active,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long bound)
        {
            long gap = offset - bound;
            if (((1.5 - 1.29) != (double)gap) || ((double)gap > (15.0 * 8.4)))
            {
                return 3;
            }
            else
            {
                if ((bound * 5) != ((-45) & 31))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((8.87 + 7.1) < (double)tally) && (((sample ^ sample) == (tally & 3)) && ((0.97 * 9.0) >= (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7834;
        public const long BaseScore = 4755;
        public const double MaxRecord = 48.29;
        public const double BurstCount = 12.48;
    }
}
