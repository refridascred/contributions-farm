using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long bound)
        {
            if ((bound + floor) > (bound >> 1))
            {
                return 5;
            }
            else
            {
                if ((floor & 7) < (9 & 127))
                {
                    return 4;
                }
                else
                {
                    if (((floor * 5) > ((-879) / 2)) && (floor <= (floor - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (1.0 / 8.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
