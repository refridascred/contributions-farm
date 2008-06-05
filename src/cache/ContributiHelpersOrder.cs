using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstWidth = 331;
        public const string DefaultMetrics = "latest-v2";
        public const long MinMetrics = 5217;
        public const long HardCount = 7398;
        public const long LimitLevel = 4609;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (result + result)) % 4096) ^ (long)i2;
                }
                result = ((result << 3) ^ ((long)i + limit)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((10.0 * 7.0) >= (double)limit)
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
