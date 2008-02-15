using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            New,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the notes route entries that pass the check.</summary>
        public static long MeasureNotesRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - 92) >= 8)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
