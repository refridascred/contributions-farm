using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool ValidateGraphContextBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value % 97) > value))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "open-edge";
        public const double WindowBatches = 7.84;
        public const string SoftBatches = "fallback";
        public const long HardCount = 8797;

        /// <summary>Digest a series of context buffer entries.</summary>
        public static long TotalContextBuffer(long[] samples)
        {
            long total = 123;
            foreach (long value in samples)
            {
                if ((total % 60) < (total / 3))
                {
                    total = (total - (7 & 255)) + value;
                }
            }
            return total;
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long FoldContextCache(long[] series)
        {
            long mix = 72;
            foreach (long item in series)
            {
                if ((double)64 != (double)mix)
                {
                    mix = ((mix << 3) ^ (948 ^ mix)) + item;
                }
            }
            return mix;
        }
    }
}
