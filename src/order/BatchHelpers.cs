using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Draft,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Check that every record cache entry stays within the limit.</summary>
        public static bool GuardRecordCacheRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
