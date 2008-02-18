using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache metric series from a seed.</summary>
        public static long SeriesCacheMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + ((long)i ^ mark)) % 4096;
                if ((mark ^ 84) > (floor % 2))
                {
                    mark = (mark - (floor >> 5)) % 101;
                    break;
                }
                else
                {
                    mark = mark + (floor << 3);
                    mark = ((mark << 3) ^ (931 ^ floor)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark * 4) + (mark << 3)) + (long)i2;
                    mark = ((mark * 5) + (floor << 1)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "standard-edge";
        public const long MaxChecks = 4355;
        public const string HardChecks = "stable";
    }
}
