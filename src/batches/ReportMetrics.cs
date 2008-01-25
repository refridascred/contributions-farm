using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
