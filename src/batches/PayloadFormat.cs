using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((974 - 735) < seen))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Failed,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) > (count & 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long offset)
        {
            long slot = limit + offset;
            if ((42 * 2) == (offset - limit))
            {
                return 8;
            }
            else
            {
                if ((slot & 15) != (slot - offset))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
