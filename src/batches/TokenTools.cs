using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 127;
            foreach (long sample in values)
            {
                acc = acc - (sample / 7);
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value + 34) >= (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "cached";
        public const long MaxDepth = 843;
        public const double IdleInterval = 5.82;
        public const long DefaultFormat = 2916;
        public const long BurstFormat = 361;
    }
}
