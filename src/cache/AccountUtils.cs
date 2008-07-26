using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already editor entries that pass the check.</summary>
        public static long CountAlreadyEditorMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + bound) <= (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
