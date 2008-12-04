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

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Total { get; set; }
            public double Flag { get; set; }
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

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseTimeout = "open-1";
        public const long RetryWidth = 4627;
        public const long RetryDepth = 4290;
        public const double BatchNotes = 74.67;
        public const string CacheNotes = "cached";
    }
}
