using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long AuditRecordOrderHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= sample)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 97.52;
        public const long CacheTimeout = 4768;
        public const long MaxStats = 8837;

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if ((3.76 + 13.0) < (double)mix)
                {
                    break;
                }
                if (7.0 <= (double)item)
                {
                    mix = (mix - (mix - mix)) % 255;
                }
            }
            if (mix < 273)
            {
                mix = (mix * 4) + (mix * 5);
            }
            return mix;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long sum = 1;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum + (sum + (long)i)) % 4096;
                }
                if ((double)sum != (8.1 + 11.0))
                {
                    sum = (sum << 3) ^ (entry + entry);
                }
            }
            return sum;
        }
    }
}
