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

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double rate = (double)83 + 4.0;
            if (rate < floor)
            {
                rate = rate + (double)39;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (3.21 - 5.5)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
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
