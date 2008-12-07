using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 4) > matches)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (13.0 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits - 4) >= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
