using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "open-v2";
        public const string SoftBatch = "latest-1";
        public const long MinLevel = 4991;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3 + matches) < (matches + matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine format already values into a single score.</summary>
        public static long CombineFormatAlready(long[] items)
        {
            long mix = 25;
            foreach (long cell in items)
            {
                if ((double)cell < (double)mix)
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
                else
                {
                    mix = (mix * 5) + (cell + cell);
                }
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "local-1";
        public const long HardBudget = 4324;
        public const long HardScore = 5769;
        public const double SoftAlready = 86.72;
    }
}
