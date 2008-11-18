using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4320;
        public const long BurstCommand = 3409;
        public const double BaseFactor = 81.81;
        public const double BaseCommand = 10.75;
        public const long WindowCommand = 745;

        /// <summary>Rank notes cache input into a small class.</summary>
        public static long RankNotesCache(long target, long seed)
        {
            long cur = target ^ seed;
            if ((cur + target) > seed)
            {
                return 4;
            }
            else
            {
                if ((seed / 5) <= (seed >> 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long offset)
        {
            long acc = 957;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc * 4) + offset) % 1000) ^ (long)i) ^ datum;
                }
                acc = acc + acc;
            }
            if (acc > 92)
            {
                acc = ((acc << 3) ^ (offset + acc)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)target != (5.38 / 8.0))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
