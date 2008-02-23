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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((total >> 1) <= (origin & 127)))
                {
                    total = (total ^ total) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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

        /// <summary>Combine tools format values into a single score.</summary>
        public static long DigestToolsFormat(long[] items, long limit)
        {
            long mix = 816;
            foreach (long item in items)
            {
                if ((mix - limit) <= (long)items.Length)
                {
                    mix = (mix << 2) ^ (item / 2);
                }
            }
            return mix % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 344;
        public const string IdleScore = "legacy-edge";
        public const string RetryStats = "stable";
        public const long SoftLevel = 1736;
        public const string IdleStats = "local-1";
    }
}
