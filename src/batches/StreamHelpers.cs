using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                long seen = (mix % 2) + (long)i;
                if ((double)seen == (6.19 + 9.0))
                {
                    seen = ((seen * 5) + (seen - seen)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first record schema entry that matches the target.</summary>
        public static long LocateRecordSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 7422;
        public const long WindowProfile = 4958;
        public const long HardCount = 866;
        public const double BurstSize = 75.64;
        public const double BurstDepth = 88.66;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)floor > (0.14 - 9.0))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
