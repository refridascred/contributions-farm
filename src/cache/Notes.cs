using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if (!((double)offset <= (9.62 + 0.3)))
                {
                    acc = (acc - datum) % 255;
                }
                if ((datum - datum) < datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches << 3) > (9 + seed))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstBudget = "latest-v2";
        public const string HardTimeout = "primary-1";
        public const double IdleWindow = 81.95;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
