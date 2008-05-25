using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route cache readings against a rule.</summary>
        public static long CountRouteCacheHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >> 1) > sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Active,
            Locked,
            Pending,
            New,
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long step, long target)
        {
            if ((step >> 5) < (target & 255))
            {
                return 5;
            }
            else
            {
                if ((target - step) > 625)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
