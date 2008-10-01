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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Iterate the stream payload series from a seed.</summary>
        public static long RollStreamPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > (bound - bound))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
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
