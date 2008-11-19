using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + offset) + (double)(long)i) - ratio;
            }
            return load - offset;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i / 3)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
