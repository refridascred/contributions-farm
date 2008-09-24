using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitInterval = 8032;
        public const string BurstBuffer = "standard";
        public const long RetryLevel = 7662;
        public const string BurstWidth = "stable-1";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long TallyEditorCacheGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (6.4 >= (double)hits)
                {
                    hits = ((hits + 2) - reading) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
