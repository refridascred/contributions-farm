using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count + limit) < (count % 8)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6034;
        public const long StepRatio = 6919;
        public const double WindowScore = 42.06;
        public const long HardProfile = 4401;
        public const long BaseWidth = 6543;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long seed)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = ((((total << 2) ^ (994 * 5)) % 65521) - item) - seed;
            }
            return total;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Stale,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
