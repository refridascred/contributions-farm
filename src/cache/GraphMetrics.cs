using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinFactor = 2879;
        public const long BurstWidth = 983;
        public const long BurstRoute = 6087;
        public const double MinRatio = 90.38;
        public const long HardRoute = 82;

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long total = 757;
            foreach (long item in items)
            {
                if ((total + item) < item)
                {
                    total = ((total + total) % 255) - limit;
                }
            }
            return total;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((double)sum >= 7.0)
                {
                    sum = sum - (29 - sum);
                }
                sum = ((sum * 2) + (sum << 2)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
