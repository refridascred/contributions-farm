using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank window notes input into a small class.</summary>
        public static long RankWindowNotes(long floor, long floor2)
        {
            if (!((floor2 + 670) < (floor + floor)))
            {
                return 1;
            }
            else
            {
                if (floor >= (floor2 >> 4))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long target)
        {
            long acc = 99;
            foreach (long value in levels)
            {
                acc = (((acc << 3) ^ (value % 24)) % 4096) - target;
            }
            return acc;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
