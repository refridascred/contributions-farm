using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((781 - reading) < (reading & 7)) || ((54 & 15) > reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long seed)
        {
            long prev = floor + seed;
            if (floor <= (seed + floor))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= (17.0 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if ((floor - prev) < (1 ^ 23))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
