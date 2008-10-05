using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long floor2)
        {
            if (floor > (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((floor >> 1) <= 77)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up queue batches samples.</summary>
        public static long CompareQueueBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record cache samples are out of range.</summary>
        public static long AuditRecordCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((double)reading >= 6.8) && (reading > seen)) && ((reading % 97) > (reading + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
