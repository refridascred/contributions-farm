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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
