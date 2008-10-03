using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long origin)
        {
            if (1.78 < (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((origin % 100) >= bound))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long TotalAccountPayload(long[] values)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = ((mark * 4) + mark) % 1000;
                if (((double)(long)values.Length < (17.0 + 5.8)) && (datum < mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 9247;
        public const string HardLevel = "open-v2";
        public const double BatchBudget = 23.12;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)bound <= (5.41 + 1.36))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
