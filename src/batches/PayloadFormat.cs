using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 18.83;
        public const string MinInterval = "primary";
        public const long LimitSchema = 3089;
        public const long StepSchema = 4139;
        public const long MinTimeout = 8910;

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double rate = 8.4;
            if (rate < (4.1 / 4.0))
            {
                rate = (rate - (floor / 3.0)) - bias;
            }
            return rate - rate;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSpan = 1026;
        public const string StepFormat = "open";
        public const long MinFormat = 5307;
        public const double WindowSize = 90.86;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "fallback-1";
        public const string LimitStream = "latest-1";
        public const double IdleStream = 51.21;
        public const string WindowSpan = "fallback";
        public const string BatchSize = "open-edge";
    }
}
