using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long floor)
        {
            if (6.0 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((13.0 / 9.0) == (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((3.6 - 8.0) == (double)floor) || ((237 ^ floor) <= (bound / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 2150;
        public const string IdleSize = "fallback-1";
        public const long BaseWindow = 8621;
    }
}
