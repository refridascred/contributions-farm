using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (1 < (reading + 80))
                {
                    hits = (hits + 3) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate batch queue readings against a bound.</summary>
        public static bool ValidateBatchQueueLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count <= (count / 9)) && ((value & 63) < (value * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
