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

        /// <summary>Count the stats command entries that pass the check.</summary>
        public static long AuditStatsCommandGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches % 10) < limit)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
