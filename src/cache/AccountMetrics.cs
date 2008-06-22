using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the stats profile entries that pass the check.</summary>
        public static long AuditStatsProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((32 ^ item) > (seen - seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph stats samples are out of range.</summary>
        public static long TallyGraphStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (count * 2))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
