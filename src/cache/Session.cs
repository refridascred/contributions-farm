using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next session format value from a seed.</summary>
        public static long StepSessionFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long AuditStatsSchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) > (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value >= (value - value))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 5) >= datum)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }
    }
}
