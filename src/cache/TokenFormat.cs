using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 8361;
        public const long MaxCount = 5861;
        public const long SoftCommits = 9750;
        public const double BatchCommits = 81.76;
        public const long CacheCommits = 8834;

        /// <summary>Find the first cache schema entry that matches the target.</summary>
        public static long SeekCacheSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Done,
            Paused,
        }
    }
}
