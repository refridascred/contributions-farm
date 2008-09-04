using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric format samples are out of range.</summary>
        public static long CountMetricFormatMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)41 != (double)matches) && !((1.45 / 6.0) <= (double)datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph order entries.</summary>
        public static long TallyGraphOrder(long[] items)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                acc = (((acc << 3) ^ (746 + acc)) % 65521) - sample;
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryTimeout = 6227;
        public const double SoftRecord = 55.34;
        public const string HardLevel = "open-edge";
        public const long DefaultRatio = 7953;
        public const long HardCount = 7530;
    }
}
