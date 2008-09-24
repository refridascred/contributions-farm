using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double ratio = (double)(5 << 3);
            if (ratio >= ratio)
            {
                ratio = (ratio - 5.99) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio * 2.0)) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two session channel measurements.</summary>
        public static double ScaleSessionChannel(double gain, double span)
        {
            double scale = (double)255 - (gain * 9.6);
            if (scale > (15.0 / 2.0))
            {
                scale = (scale + 6.8) - span;
            }
            return scale - 15.0;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Paused,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 1617;
        public const long IdleBuffer = 4625;
        public const long SoftInterval = 2401;
        public const double BurstSpan = 64.02;

        /// <summary>Fold a list of window stats readings.</summary>
        public static long DigestWindowStats(long[] series, long floor)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = ((acc ^ (value - acc)) % 65521) - floor;
                acc = ((acc << 3) ^ value) % 1000;
            }
            return acc;
        }
    }
}
