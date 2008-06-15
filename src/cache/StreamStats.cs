using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items, long seed)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                acc = ((acc + reading) % 101) + seed;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long mark = 35;
            foreach (long item in values)
            {
                if (item >= (mark % 2))
                {
                    mark = mark + (item ^ item);
                }
                if ((mark + mark) <= item)
                {
                    break;
                }
            }
            if (mark > 24)
            {
                mark = (mark << 2) ^ (mark >> 3);
            }
            return mark % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseInterval = "open-1";
        public const string StepDepth = "latest-1";
        public const long DefaultAccount = 6135;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (offset - hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
