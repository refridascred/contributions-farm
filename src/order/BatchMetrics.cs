using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "primary-v2";
        public const long MaxAccount = 8937;
        public const double LimitAccount = 30.25;
        public const string RetrySize = "legacy-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4248;
        public const string MaxSpan = "cached";
        public const double LimitSize = 0.57;
        public const string BatchInterval = "legacy-v2";

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < offset)
            {
                bias2 = (bias2 + (bias2 / 8.0)) + bias;
            }
            return bias2 + (6.0 / 9.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 73.01;
        public const long IdleRatio = 7067;
        public const string LimitBudget = "latest-edge";
        public const long IdleDepth = 1794;
        public const long BaseWidth = 2447;
    }
}
