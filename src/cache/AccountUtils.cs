using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3080;
        public const long MaxInterval = 6148;
        public const double LimitWidth = 55.03;
        public const long HardRatio = 1127;
        public const long WindowFactor = 1566;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i >> 4);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }
    }
}
