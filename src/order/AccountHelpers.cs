using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Active,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double scale = bias;
            if (scale < 2.49)
            {
                scale = scale - (double)978;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset - offset)) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const double RetryTimeout = 6.66;
        public const long BurstCount = 4813;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultWidth = "local-edge";
        public const long SoftReport = 3660;
        public const long RetryReport = 7835;
        public const double StepCount = 55.91;
        public const long StepTimeout = 9424;
    }
}
