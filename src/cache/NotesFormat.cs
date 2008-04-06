using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up cache buffer samples.</summary>
        public static long MatchCacheBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-edge";
        public const string SoftFactor = "fallback-v2";
        public const string BatchLevel = "alpha-edge";
        public const string HardToken = "cached-v2";
        public const long DefaultSize = 1163;

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultLevel = 0.99;
        public const long HardCommand = 4386;
        public const string CacheCommand = "latest";
        public const long SoftDepth = 459;
        public const long StepCommand = 2047;
    }
}
