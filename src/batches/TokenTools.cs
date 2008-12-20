using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = (result * 3) + 743;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
