using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a metrics checks sample.</summary>
        public static long LookupMetricsChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric context entries that pass the check.</summary>
        public static long TallyMetricContextOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 4) == (hits - 44))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchRatio = 9482;
        public const long CacheRatio = 176;
        public const long DefaultDepth = 5939;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally >= (tally << 2))
                {
                    tally = ((tally + 3) + entry) - offset;
                }
            }
            return tally;
        }
    }
}
