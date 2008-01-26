using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long offset, long seed)
        {
            long delta = offset + seed;
            if ((seed << 2) < (delta - seed))
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) != (delta - 46))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((13.0 / 5.0) > (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
