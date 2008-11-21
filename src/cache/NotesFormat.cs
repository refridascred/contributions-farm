using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Draft,
            Done,
            Active,
            Paused,
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
