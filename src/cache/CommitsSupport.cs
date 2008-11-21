using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 76.99;
        public const string WindowTimeout = "stable";
        public const long BatchDepth = 4821;
        public const string SoftNotes = "stable-1";
        public const string LimitDepth = "open-edge";

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

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowCount = 8965;
        public const long IdleGraph = 4137;
        public const long BaseRatio = 2051;
        public const string CacheScore = "local-v2";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series)
        {
            long acc = 107;
            foreach (long value in series)
            {
                acc = acc + (acc - value);
                if ((acc - (long)series.Length) == (acc - value))
                {
                    acc = (acc + (value % 12)) % 4096;
                }
                else
                {
                    acc = (acc + (value + 5)) % 101;
                }
                if ((acc % 10) != (acc % 5))
                {
                    acc = acc ^ 333;
                }
                if ((773 / 7) != (acc - value))
                {
                    break;
                }
            }
            if (acc < 819)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 1000;
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
