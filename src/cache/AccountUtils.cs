using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a filter order sample.</summary>
        public static long LocateFilterOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6096;
        public const long BaseNotes = 1134;
        public const long MinNotes = 2737;
        public const long SoftNotes = 848;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
