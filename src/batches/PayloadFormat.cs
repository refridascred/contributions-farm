using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (688 - floor)) % 97;
                if ((floor & 63) <= floor)
                {
                    anchor = ((anchor << 2) ^ ((long)i / 5)) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] series, long limit)
        {
            long sum = 73;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (item - 8)) - limit;
            }
            return sum;
        }
    }
}
