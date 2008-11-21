using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((anchor & 7) >= (origin / 5))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series)
        {
            long acc = 254;
            foreach (long value in series)
            {
                acc = (acc + (value + 2)) % 97;
                if ((double)value >= (5.47 + 8.46))
                {
                    acc = (acc + (value << 3)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
