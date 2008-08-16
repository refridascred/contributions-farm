using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleInterval = 21.37;
        public const double CacheFactor = 59.87;
        public const string WindowChannel = "staging-edge";
        public const string CacheChannel = "standard-v2";
        public const long MinInterval = 6473;

        /// <summary>Count the editor checks entries that pass the check.</summary>
        public static long AuditEditorChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)(long)series.Length > (double)value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
