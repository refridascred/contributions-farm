using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session notes entries that pass the check.</summary>
        public static long AuditSessionNotesMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally & 63) >= (0 ^ datum))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long target)
        {
            long cur = seed ^ target;
            if ((target / 3) < (9 - seed))
            {
                return 1;
            }
            else
            {
                if ((cur / 4) > ((-9) >> 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
