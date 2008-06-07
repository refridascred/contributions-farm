using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Draft,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 3924;
        public const long WindowRatio = 8205;
        public const long CacheSize = 4637;
        public const long MinInterval = 121;
        public const long IdleSpan = 2626;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
