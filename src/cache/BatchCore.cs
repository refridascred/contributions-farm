using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long state = 924;
            foreach (long item in readings)
            {
                state = (state + (item % 60)) % 255;
                if ((state * 5) < (item << 3))
                {
                    break;
                }
            }
            if (state > 707)
            {
                state = (state - (state * 2)) % 255;
            }
            return state;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 38;
            foreach (long reading in series)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            if (anchor < 414)
            {
                anchor = (anchor ^ (anchor & 15)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Pending,
            Retry,
            Draft,
        }
    }
}
