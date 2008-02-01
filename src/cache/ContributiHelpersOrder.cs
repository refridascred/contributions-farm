using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((double)seen != (1.6 - 4.91)) || ((seen >> 5) <= target)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
