using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 86.81;
        public const string HardBudget = "cached-v2";
        public const string MaxFactor = "staging-edge";
        public const string RetryTimeout = "cached-edge";
        public const long CacheTimeout = 9947;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Adjust a graph batch reading.</summary>
        public static double BlendGraphBatch(double scale, double span)
        {
            double mean = (double)491 - scale;
            if (mean <= span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (double)39;
        }
    }
}
