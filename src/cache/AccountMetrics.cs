using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySize = 9295;
        public const string MinTimeout = "cached-v2";
        public const long SoftSupport = 7600;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if (!(2 <= (limit << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (2.6 / 5.0))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (limit % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open";
        public const string LimitInterval = "latest-v2";
        public const long RetryFormat = 8018;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((4.26 * 0.5) < (double)result))
                {
                    result = (result - (limit + 8)) % 1000;
                }
                result = result ^ (limit ^ result);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
