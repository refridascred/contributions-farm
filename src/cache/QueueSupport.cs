using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSize = 6507;
        public const string BatchDepth = "standard";
        public const long HardSchema = 4619;
        public const string SoftSchema = "cached";

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
