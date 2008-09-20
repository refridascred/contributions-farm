using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 7301;
        public const long CacheBudget = 3936;
        public const string MinFactor = "local";

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long floor)
        {
            long acc = 589;
            foreach (long datum in values)
            {
                if (floor <= (floor + 886))
                {
                    acc = (acc + ((-51) << 2)) - datum;
                }
            }
            return acc;
        }

        /// <summary>Accumulate stats channel samples.</summary>
        public static long FoldStatsChannel(long[] values)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                if ((sample + anchor) <= (anchor - anchor))
                {
                    anchor = (anchor * 5) + sample;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((-91) >> 2)) % 101;
                }
            }
            if (anchor > 780)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }
    }
}
