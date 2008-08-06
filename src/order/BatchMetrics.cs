using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally + sample) == ((long)items.Length / 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 3) == (cell / 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate checks farm readings against a bound.</summary>
        public static bool ValidateChecksFarmLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate order account readings against a bound.</summary>
        public static bool GuardOrderAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
