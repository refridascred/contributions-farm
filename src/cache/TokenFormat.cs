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

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long acc = 13;
            foreach (long datum in data)
            {
                acc = (((acc << 3) ^ (acc ^ acc)) % 4096) - datum;
                acc = acc ^ (acc << 2);
                acc = (acc - acc) % 4096;
            }
            return acc % 1000;
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
