using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ (origin - total)) % 1000;
                if (42 >= (origin + origin))
                {
                    total = (total * 5) + ((long)i % 10);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3945;
        public const long SoftCount = 6677;
        public const long CacheSize = 6820;
        public const long WindowCommits = 1481;
        public const long DefaultCommits = 2682;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinDepth = "alpha-edge";
        public const long LimitNotes = 8749;
        public const double CacheNotes = 33.17;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Synced,
            Retry,
        }
    }
}
