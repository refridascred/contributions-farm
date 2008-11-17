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

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowBudget = 6592;
        public const long CacheQueue = 3605;
        public const long WindowQueue = 6080;

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
