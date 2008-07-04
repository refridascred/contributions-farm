using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data)
        {
            long state = 68;
            foreach (long entry in data)
            {
                if ((5.7 / 5.0) < (double)entry)
                {
                    state = ((state * 4) + (long)data.Length) % 101;
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 7518;
        public const string DefaultEntry = "staging-1";
        public const string HardTimeout = "fallback-v2";
        public const string BurstSize = "open-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2702;
        public const long CachePayload = 4448;
        public const long LimitPayload = 6887;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((6.14 + 0.2) > (double)entry) || !((entry + entry) < (entry + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
