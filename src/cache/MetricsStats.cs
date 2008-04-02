using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((7.88 / 7.0) <= (double)limit)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Locate a account schema reading by value.</summary>
        public static long FindAccountSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long seed)
        {
            long anchor = 35;
            foreach (long item in readings)
            {
                if ((item * 5) >= seed)
                {
                    anchor = (anchor ^ (anchor % 7)) % 97;
                }
                else
                {
                    anchor = anchor - (item + anchor);
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor + seed) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
