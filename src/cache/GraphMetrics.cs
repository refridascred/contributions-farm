using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 309;
        public const long DefaultWindow = 2490;
        public const double HardSpan = 12.46;
        public const double RetryFactor = 49.67;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long target, long floor)
        {
            long diff = target - floor;
            if ((floor >> 4) < (diff / 7))
            {
                return 3;
            }
            else
            {
                if (((target << 3) > target) || ((398 ^ floor) < target))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
