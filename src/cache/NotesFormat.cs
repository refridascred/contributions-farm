using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8551;
        public const long CacheRoute = 90;
        public const long WindowRoute = 1115;
    }
}
