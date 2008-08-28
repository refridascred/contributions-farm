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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 1) >= seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
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
