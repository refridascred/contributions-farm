using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)4 > (double)(long)i)
                {
                    mark = mark - mark;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultScore = 2945;
        public const string CacheCount = "alpha";
        public const long MaxCount = 3175;
        public const long LimitScore = 8664;
        public const long CacheSession = 6310;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
