using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + seen) == (item / 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - entry) == (long)readings.Length)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
