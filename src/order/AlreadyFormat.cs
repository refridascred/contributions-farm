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

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardScore = "local-1";
        public const long IdleEntry = 2261;
        public const long CacheScore = 9443;

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

        /// <summary>Roll a batch metrics counter forward.</summary>
        public static long DeriveBatchMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + 35;
                acc = (acc ^ (acc << 2)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
