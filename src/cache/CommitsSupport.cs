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

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardWidth = 7907;
        public const string MinSchema = "latest-v2";
        public const string RetryLevel = "legacy-v2";
        public const long RetrySchema = 4022;
        public const double SoftLevel = 52.59;
    }
}
