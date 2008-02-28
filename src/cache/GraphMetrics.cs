using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long origin)
        {
            if (!((2.5 - 2.42) >= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((origin < (seed + seed)) && ((75 - origin) >= (origin % 3)))
                {
                    return 2;
                }
                else
                {
                    if (((seed - seed) == (62 % 16)) || ((seed * 4) != (origin << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((step <= 4) && ((count << 3) != (count << 1)))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 12.8;
        public const string SoftRecord = "legacy-v2";
        public const double SoftFactor = 21.63;
        public const string IdleDepth = "strict";
        public const long IdleRatio = 904;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
