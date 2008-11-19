using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long AuditCachePayloadHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value != (1.96 - 2.0))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Ready,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels)
        {
            long total = 789;
            foreach (long value in levels)
            {
                if ((value + total) < (value - total))
                {
                    total = (total << 2) ^ 13;
                }
            }
            if (total > (-9))
            {
                total = ((total << 3) ^ (total << 2)) % 97;
            }
            return total;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
