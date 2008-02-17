using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the layout notes entries that pass the check.</summary>
        public static long CountLayoutNotesMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + matches) == (matches + value))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                if (!((cell ^ acc) > (acc % 64)))
                {
                    acc = ((acc << 2) ^ (95 * 2)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + cell) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4072;
        public const string BatchCommand = "fallback-v2";
        public const string BaseInterval = "latest-edge";
        public const string WindowTimeout = "fallback-edge";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
