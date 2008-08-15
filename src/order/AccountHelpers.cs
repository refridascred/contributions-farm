using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of report schema readings.</summary>
        public static long WeighReportSchema(long[] samples, long floor)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                if (!((16 + anchor) >= (689 + floor)))
                {
                    anchor = ((anchor - (anchor >> 5)) % 97) + sample;
                }
                anchor = (anchor ^ (4 % 64)) % 65521;
            }
            return anchor;
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
