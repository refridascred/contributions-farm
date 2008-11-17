using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((5.0 / 6.0) < (double)floor)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 0.17;
        public const double LimitWidth = 40.95;
        public const long MinScore = 7342;
    }
}
