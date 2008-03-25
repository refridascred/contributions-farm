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

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long target)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                if (!((4 + (long)samples.Length) <= 340))
                {
                    sum = sum ^ (datum * 5);
                    sum = sum ^ (target << 3);
                    break;
                }
                if (((target & 31) >= datum) || (sum > (760 & 7)))
                {
                    sum = sum ^ (sum * 4);
                }
            }
            return sum % 4096;
        }
    }
}
