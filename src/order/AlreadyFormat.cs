using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((acc << 1) >= (acc + seed)))
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Retry,
            Dropped,
            New,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 4923;
        public const long DefaultNotes = 9517;
        public const long SoftTimeout = 7829;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
