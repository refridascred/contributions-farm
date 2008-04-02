using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next layout tools value from a seed.</summary>
        public static long SeriesLayoutTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + offset) > ((-9) % 12))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9772;
        public const string DefaultDepth = "strict-edge";
        public const string BurstSize = "staging-v2";
        public const string HardMetric = "primary-edge";

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long target)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((target + item) > item)
                {
                    break;
                }
                acc = ((acc * 4) + (item - acc)) % 4096;
            }
            if (acc > 27)
            {
                acc = ((acc << 3) ^ (target & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen >= 6.7)
                {
                    seen = ((seen + 3) ^ entry) + origin;
                }
            }
            return seen;
        }
    }
}
