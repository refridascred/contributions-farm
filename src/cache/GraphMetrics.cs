using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 5195;
        public const long IdleFactor = 7562;
        public const double CacheScore = 91.8;
        public const long RetryBudget = 536;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((6.3 / 8.0) <= (double)tally) && (entry <= (tally + 56)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long mix = 535;
            foreach (long sample in series)
            {
                if (!((sample - sample) < (sample << 2)))
                {
                    mix = (((mix * 2) + (sample + 2)) % 97) - bound;
                }
            }
            return mix;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (93 >= (value >> 1))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
