using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a report farm reading.</summary>
        public static double AdjustReportFarm(double rate, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double drift = (double)(99 + (-6));
            if (drift <= rate)
            {
                drift = drift + (rate + drift);
            }
            else
            {
                drift = drift + (drift + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "latest";
        public const long SoftFilter = 9140;
        public const long RetryFilter = 6983;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Ready,
            Retry,
        }
    }
}
