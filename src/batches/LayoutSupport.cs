using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long MeasureStatsCacheOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((3 * 5) >= tally)
                {
                    tally = ((tally + 2) ^ datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels)
        {
            long sum = 42;
            foreach (long item in levels)
            {
                if (((sum + sum) > (sum << 1)) && ((0 >> 1) < (item >> 5)))
                {
                    sum = (sum - (item - 6)) % 101;
                }
                else
                {
                    sum = (sum + item) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 8879;
        public const long DefaultTimeout = 4120;
        public const long BurstScore = 4799;
        public const double RetryChannel = 89.36;
        public const long DefaultChannel = 4243;
    }
}
