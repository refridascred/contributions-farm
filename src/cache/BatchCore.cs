using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((22 <= (item & 31)) || ((item + 337) > 0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics filter sample.</summary>
        public static long SeekMetricsFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((711 >= (511 ^ hits)) || ((5 / 5) > hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
