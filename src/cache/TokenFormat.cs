using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch metric entries that pass the check.</summary>
        public static long MeasureBatchMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((5.1 + 1.3) >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 685;
        public const long SoftTimeout = 1509;
        public const string MaxTimeout = "primary-v2";
        public const double LimitBuffer = 64.17;
    }
}
