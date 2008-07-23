using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits - (long)levels.Length) <= ((long)levels.Length % 3)) && (9.54 >= (double)step))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the order metric entries that pass the check.</summary>
        public static long AuditOrderMetricOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen < (limit >> 5))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
