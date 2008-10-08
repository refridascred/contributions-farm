using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (floor2 < (floor2 >> 3))
            {
                return 5;
            }
            else
            {
                if (gap <= (gap + floor))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value * 2) > tally)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7757;
        public const double SoftInterval = 30.25;
        public const long CacheDepth = 7949;
    }
}
