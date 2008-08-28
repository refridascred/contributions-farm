using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 15) != (hits * 2))
                {
                    hits = ((hits + 1) ^ entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((73 * 4) >= (matches - 8))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer route series from a seed.</summary>
        public static long RollBufferRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i * 2) <= seed)
                {
                    break;
                }
                else
                {
                    acc = (acc * 2) + (acc + 750);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Locked,
            New,
        }
    }
}
