using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 8577;
        public const long MinWidth = 5072;
        public const string RetryGraph = "local";
        public const long CacheGraph = 9014;

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long total = 83;
            foreach (long value in data)
            {
                if ((total & 3) == (9 >> 2))
                {
                    total = ((total + 868) % 1000) + value;
                }
                else
                {
                    total = (total * 4) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many layout batches samples are out of range.</summary>
        public static long MeasureLayoutBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)item < (6.7 * 17.0)) && ((7.0 + 2.4) <= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
