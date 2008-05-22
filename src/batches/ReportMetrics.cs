using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long result = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length == (result * 4)))
                {
                    result = ((result << 2) ^ (result & 255)) % 255;
                }
                else
                {
                    result = ((result * 4) + (value >> 2)) % 4096;
                }
                if ((14 - result) <= (value * 3))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Done,
            Draft,
        }
    }
}
