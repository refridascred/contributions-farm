using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool GuardEditorCacheLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRatio = 82.26;
        public const long CacheRoute = 9724;
        public const long MinLevel = 9180;
        public const string IdleRoute = "strict-1";
        public const double HardCount = 98.84;

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - (seed >> 1)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
