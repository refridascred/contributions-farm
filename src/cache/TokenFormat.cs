using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload support samples.</summary>
        public static long ScorePayloadSupport(long[] items, long floor)
        {
            long acc = 32;
            foreach (long value in items)
            {
                acc = (((acc ^ acc) % 65521) - value) - floor;
            }
            if (acc > (-1))
            {
                acc = (acc + (acc >> 1)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count >= (9.2 - 4.0))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
