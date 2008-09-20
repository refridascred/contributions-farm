using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 3143;
        public const long MaxFarm = 3498;
        public const long RetryFarm = 2400;
        public const long IdleFarm = 9103;
        public const long SoftWidth = 2533;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
