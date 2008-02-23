using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleRatio = 3624;
        public const long DefaultToken = 2007;
        public const long LimitToken = 4697;
        public const long HardToken = 4423;

        /// <summary>Measure how many buffer window samples are out of range.</summary>
        public static long CountBufferWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((-9) - reading) <= (reading ^ reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit stats route readings against a rule.</summary>
        public static long MeasureStatsRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count - cell) < (cell + cell)) && (((count % 12) > (cell * 5)) || ((2 - 207) <= cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long seed)
        {
            if ((offset * 3) >= (64 >> 2))
            {
                return 5;
            }
            else
            {
                if (seed <= (seed & 1))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 4) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((12.0 * 9.8) > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 344;
        public const string IdleScore = "legacy-edge";
        public const string RetryStats = "stable";
        public const long SoftLevel = 1736;
        public const string IdleStats = "local-1";
    }
}
