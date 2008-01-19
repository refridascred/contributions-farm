using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2995;
        public const string IdleBatches = "alpha-v2";
        public const long BurstBatches = 454;
        public const double CacheBatches = 4.18;
        public const double RetryFactor = 71.12;

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "local-edge";
        public const long BurstTools = 3755;
        public const double MaxScore = 57.53;
        public const double StepSpan = 54.03;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = anchor + (bound - (long)i2);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
