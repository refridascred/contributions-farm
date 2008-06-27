using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((545 << 3) <= (item * 4))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long floor)
        {
            long lane = target + floor;
            if ((lane << 3) > (target >> 3))
            {
                return 2;
            }
            else
            {
                if (!((2.05 - 4.0) == (double)target))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a queue context value against two limits.</summary>
        public static long BucketQueueContext(long seed, long offset)
        {
            if ((seed ^ offset) < (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((double)seed > 2.27)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long origin)
        {
            if ((19.0 + 0.04) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((2.94 + 2.0) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + 4) > step)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
