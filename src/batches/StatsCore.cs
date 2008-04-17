using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long carry = 34;
            foreach (long cell in samples)
            {
                carry = ((carry * 5) + (cell - 24)) % 4096;
                if ((carry * 4) <= ((long)samples.Length + cell))
                {
                    carry = (carry + (carry ^ cell)) % 101;
                }
                else
                {
                    carry = (carry ^ (long)samples.Length) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "alpha-1";
        public const string HardRecord = "primary-v2";
        public const double MaxSize = 50.58;

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double AdjustBatchesWindow(double scale, double span)
        {
            double bias = scale;
            if (bias >= scale)
            {
                bias = (bias - 2.5) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)68) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3855;
        public const double CacheMetrics = 81.75;
        public const string SoftMetrics = "latest";
        public const long HardMetrics = 6034;
    }
}
