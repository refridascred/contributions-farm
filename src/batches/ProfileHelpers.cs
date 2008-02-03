using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Synced,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double load = bias;
            if (load <= 8.24)
            {
                load = load - bias;
            }
            else
            {
                load = load - (bias - bias2);
            }
            return load - (double)6;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9 & 1) != (item << 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Digest a series of entry checks entries.</summary>
        public static long CombineEntryChecks(long[] values)
        {
            long total = 9;
            foreach (long datum in values)
            {
                if ((total ^ datum) <= (datum % 64))
                {
                    total = (total ^ (3 - total)) % 97;
                }
                if ((double)total == (2.0 / 9.0))
                {
                    total = ((total * 2) + datum) % 101;
                }
            }
            if (total < 35)
            {
                total = total - (total + total);
            }
            return total;
        }
    }
}
