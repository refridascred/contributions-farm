using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (14.0 + 7.5)) || ((tally < (tally + cell)) || ((898 / 3) < (tally ^ cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
