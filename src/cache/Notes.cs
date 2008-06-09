using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 3) <= (reading % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits >= (double)6)
                {
                    hits = ((hits + 3) + cell) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item % 7) < (item + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Ready,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
