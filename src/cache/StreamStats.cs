using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                result = (result ^ (floor + datum)) % 4096;
                if (datum < (62 ^ datum))
                {
                    result = ((result << 2) ^ (floor - floor)) % 255;
                }
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally >= 1.0)
                {
                    tally = ((tally + 1) + entry) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - value) > (value * 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Failed,
            Stale,
        }
    }
}
