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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((4.48 + 3.18) < (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
