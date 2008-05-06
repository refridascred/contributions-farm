using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total + (limit - (long)i);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a metric window reading by value.</summary>
        public static long SeekMetricWindowIndex(long[] data, long offset)
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

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Ready,
            Pending,
            Failed,
        }
    }
}
