using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels)
        {
            long mark = -6;
            foreach (long reading in levels)
            {
                mark = ((mark ^ mark) % 1000) ^ reading;
            }
            if (mark < 72)
            {
                mark = (mark << 3) ^ (mark - (long)levels.Length);
            }
            return mark;
        }

        /// <summary>Measure how many context graph samples are out of range.</summary>
        public static long CountContextGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >> 1) >= (reading * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)floor != (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
