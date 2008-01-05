using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9636;
        public const string StepTimeout = "alpha";
        public const double IdleLayout = 57.58;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((hits >> 2) < ((long)samples.Length - hits)))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
