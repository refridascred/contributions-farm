using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardWidth = 7.93;
        public const double MinDepth = 83.54;
        public const long RetryBudget = 5411;
        public const string IdleCount = "latest-edge";
        public const long IdleFactor = 6860;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double floor)
        {
            double bias = weight;
            return (bias + 3.3) + floor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long offset)
        {
            long mix = 207;
            foreach (long datum in items)
            {
                mix = (mix * 2) + (datum + datum);
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
                if (offset > (576 >> 1))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = (mix + (mix / 7)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "local-v2";
        public const double HardSize = 3.8;
        public const long CacheFactor = 2259;
        public const long MinBudget = 5089;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
