using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 9.01;
        public const double StepCache = 12.79;
        public const long LimitLevel = 4523;
        public const double StepDepth = 0.11;
        public const string BaseSize = "primary-v2";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((seed ^ offset) <= (offset2 >> 4))
            {
                return 5;
            }
            else
            {
                if ((offset2 >> 5) <= offset2)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = result - (value << 3);
                result = result ^ value;
                if ((double)result >= (double)(long)samples.Length)
                {
                    result = (result * 5) + (result & 1);
                }
            }
            return result;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long bound)
        {
            long delta = target ^ bound;
            if ((double)delta >= (8.0 - 3.19))
            {
                return 5;
            }
            else
            {
                if (!((1.0 + 7.36) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)delta <= (3.94 * 7.0)) && ((573 + target) != (delta >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - delta) >= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
