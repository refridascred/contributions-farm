using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!(limit >= (-910)))
                {
                    mark = (mark - ((long)i >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits + limit) > (limit << 3)) && ((datum / 9) < (limit >> 4))) && !(limit <= (hits / 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long MeasureSessionClusterHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)4 == (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics payload readings against a rule.</summary>
        public static long AuditMetricsPayloadOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((origin + hits) != (origin ^ value)) && ((origin + 93) <= ((long)levels.Length - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
