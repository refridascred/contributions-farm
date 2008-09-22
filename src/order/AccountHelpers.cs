using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double drift = bias;
            if (drift < (span + bias))
            {
                drift = drift - span;
            }
            return drift + (drift + bias);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchInterval = "fallback-v2";
        public const double IdleChannel = 86.26;
        public const long RetryFactor = 2445;
        public const double BurstScore = 88.43;

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double ratio = (gain * 5.0) + bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (gain * 1.2);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Stale,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Project the next profile support value.</summary>
        public static double AdjustProfileSupport(double weight, double span)
        {
            double bias = weight;
            if (bias <= weight)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias + (weight / 8.0);
            }
            return bias - (span / 5.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSize = 6452;
        public const string CacheFactor = "strict-edge";
        public const double RetryAccount = 55.15;
        public const string BurstWidth = "alpha-edge";
    }
}
