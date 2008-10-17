using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ seen) <= seen)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long offset, long limit)
        {
            if (limit >= offset)
            {
                return 2;
            }
            else
            {
                if ((limit + offset) != (offset << 3))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
