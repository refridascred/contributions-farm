using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(matches > 7))
                {
                    matches = ((matches + 2) - reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Pending,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Paused,
            Retry,
        }
    }
}
