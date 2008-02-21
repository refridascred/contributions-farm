using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long FindFormatStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
