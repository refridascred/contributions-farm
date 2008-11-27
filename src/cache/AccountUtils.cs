using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRatio = 11.78;
        public const double BatchSize = 29.21;
        public const string MaxRecord = "latest";
        public const long WindowRecord = 7039;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((863 / 2) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 9.0)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (origin2 - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 >= (bound / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache report samples are out of range.</summary>
        public static long MeasureCacheReportHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((4.15 + 16.0) != (double)matches) && ((entry - entry) >= entry))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
