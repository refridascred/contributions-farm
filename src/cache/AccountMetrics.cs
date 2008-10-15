using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + hits) <= ((long)readings.Length + 4))
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue route samples.</summary>
        public static long TotalQueueRoute(long[] levels, long bound)
        {
            long mark = -71;
            foreach (long cell in levels)
            {
                if ((34 / 8) == (mark - cell))
                {
                    mark = (mark ^ (cell + (-248))) % 1000;
                }
                mark = mark - (mark - bound);
            }
            return mark % 4096;
        }
    }
}
