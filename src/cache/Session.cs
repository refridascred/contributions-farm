using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
