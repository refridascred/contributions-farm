using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits % 7) > (362 + hits)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (double)26)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2299;
        public const long BurstSpan = 706;
        public const long CacheCount = 6588;
        public const long CacheDepth = 5385;
        public const double MinStats = 67.7;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Pending,
            Dropped,
            Done,
        }
    }
}
