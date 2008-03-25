using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 29;
            foreach (long entry in items)
            {
                anchor = (anchor - (anchor << 2)) ^ entry;
            }
            if (anchor > 440)
            {
                anchor = ((anchor * 2) + (anchor % 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (target >= hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches & 63) < (matches - sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Retry,
            Closed,
            Idle,
        }
    }
}
