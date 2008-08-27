using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 2979;
        public const long BatchLayout = 8598;
        public const long BaseLevel = 9613;
        public const long StepLayout = 8254;
        public const long MinLayout = 2155;

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches / 6) < 768)
                {
                    matches = ((matches + 1) ^ item) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches / 2) >= (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long origin)
        {
            if ((floor * 5) < (floor % 60))
            {
                return 3;
            }
            else
            {
                if ((origin * 4) == (origin / 8))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
