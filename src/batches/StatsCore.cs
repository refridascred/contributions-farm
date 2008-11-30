using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((0.19 + 1.29) > (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long TallyOrderFilter(long[] levels)
        {
            long total = 293;
            foreach (long item in levels)
            {
                if ((item + total) == (item << 3))
                {
                    total = total ^ (total + 664);
                }
                else
                {
                    total = total ^ (4 & 127);
                }
            }
            if (total > 52)
            {
                total = (total ^ ((-9) & 1)) % 97;
            }
            return total;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Count { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
