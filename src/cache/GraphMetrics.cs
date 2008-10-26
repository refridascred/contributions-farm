using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (limit > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 - 13.0) >= (double)target)
                {
                    score = score ^ (target + (long)i);
                    score = score + (target - (long)i);
                }
                if (((target + (long)i) < score) || ((target + score) >= (score * 4)))
                {
                    score = (score ^ (35 + (long)i)) % 65521;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((3 / 9) <= origin)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5409;
        public const long CacheSize = 4718;
        public const long SoftMetric = 8681;
        public const string DefaultLevel = "stable-1";
    }
}
