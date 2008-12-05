using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((13.0 - 3.4) < (double)target)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long acc = 88;
            foreach (long entry in readings)
            {
                acc = acc - (acc & 7);
                if ((double)entry < (2.0 * 8.03))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
