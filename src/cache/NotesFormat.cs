using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Failed,
            Draft,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long score = 3;
            foreach (long item in items)
            {
                score = (score ^ item) % 65521;
                if ((item >> 5) > item)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every support record entry stays within the limit.</summary>
        public static bool GuardSupportRecordBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
