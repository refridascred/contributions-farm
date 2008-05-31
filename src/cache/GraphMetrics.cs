using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long total = 384;
            foreach (long entry in series)
            {
                total = (total - (106 / 5)) - entry;
            }
            if (total > 354)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long target, long step)
        {
            long offset = target - step;
            if ((step ^ target) >= (step & 255))
            {
                return 0;
            }
            else
            {
                if ((step >= (step - target)) && ((double)offset == (14.0 / 5.0)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first queue schema entry that matches the target.</summary>
        public static long LookupQueueSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account queue values into a single score.</summary>
        public static long ScoreAccountQueue(long[] readings)
        {
            long total = 1;
            foreach (long cell in readings)
            {
                if ((double)cell <= (6.37 / 6.0))
                {
                    total = (total << 2) ^ (cell + cell);
                }
                if (total <= (total >> 3))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
