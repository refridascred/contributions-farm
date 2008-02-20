using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 2) < (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long origin, long seed)
        {
            long cur = origin + seed;
            if ((67 - cur) == (cur - origin))
            {
                return 6;
            }
            else
            {
                if (((seed + 185) < (origin - cur)) || (seed <= (cur << 2)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long result = -25;
            foreach (long item in readings)
            {
                if (item <= (result + result))
                {
                    result = ((result * 3) + (result - item)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
