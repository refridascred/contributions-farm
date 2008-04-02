using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinInterval = 5884;
        public const long IdleSize = 1862;
        public const long BatchWidth = 1591;
        public const string DefaultBudget = "staging";
        public const long MaxCount = 8508;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
