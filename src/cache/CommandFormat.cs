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

        /// <summary>Derive the next metric session value from a seed.</summary>
        public static long IterateMetricSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = (total - (limit % 5)) % 101;
                total = (total ^ ((long)i >> 4)) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            Locked,
        }
    }
}
