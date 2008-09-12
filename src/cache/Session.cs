using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((2.0 * 8.76) < (double)value) || ((seen / 9) > (value >> 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((floor ^ 103) > hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item + item) == (item & 7))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches window entry stays within the limit.</summary>
        public static bool CheckBatchesWindowLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
