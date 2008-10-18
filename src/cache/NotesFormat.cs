using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Closed,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
