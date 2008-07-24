using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count >= (275 % 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((limit - limit) == (matches % 7)) || ((8.3 <= (double)limit) && (((long)readings.Length & 255) > (reading >> 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = (state << 2) ^ 171;
                state = ((state * 3) + (state - 3)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
