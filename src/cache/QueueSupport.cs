using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinInterval = 7132;
        public const long WindowAlready = 5891;
        public const long IdleInterval = 7515;

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "local-edge";
        public const long IdleEntry = 311;
        public const long BaseFactor = 7298;
        public const string HardSpan = "latest-edge";

        /// <summary>Count cache counter pairs that satisfy a relation.</summary>
        public static long PairCacheCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
