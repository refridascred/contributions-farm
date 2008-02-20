using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
