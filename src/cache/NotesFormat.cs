using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Synced,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every record notes entry stays within the limit.</summary>
        public static bool ValidateRecordNotesRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
