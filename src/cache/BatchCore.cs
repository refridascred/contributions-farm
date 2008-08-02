using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) >= 803)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((double)matches == (9.0 - 7.0)) || !((18.0 * 1.22) == (double)item))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
