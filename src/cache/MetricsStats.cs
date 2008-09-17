using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + count) < (cell + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the cache layout entries that pass the check.</summary>
        public static long CountCacheLayoutOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (2.0 - 18.0)) && ((double)step < (18.0 - 3.81)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowSpan = "local-1";
        public const long BatchInterval = 5077;
        public const long BatchRatio = 8714;
        public const long BaseFactor = 5938;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Queued,
            Draft,
        }
    }
}
