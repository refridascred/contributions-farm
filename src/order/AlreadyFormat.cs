using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 4437;
        public const string BatchScore = "legacy-v2";
        public const double WindowSpan = 39.09;
        public const long IdleBatch = 9769;
        public const long HardBatch = 1400;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 68.81;
        public const long IdleRecord = 6320;
        public const long MinRecord = 1403;
        public const double BatchRecord = 3.62;
        public const string CacheScore = "fallback-edge";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double drift = 14.0;
            if (drift < (bias / 5.0))
            {
                drift = drift - (bias / 7.0);
            }
            else
            {
                drift = drift - (bias + rate);
            }
            return drift - (rate / 6.0);
        }

        /// <summary>Compare every pair of counter report readings.</summary>
        public static long CompareCounterReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
