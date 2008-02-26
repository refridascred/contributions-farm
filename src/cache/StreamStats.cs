using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultCount = "staging-edge";
        public const long BaseTools = 8490;
        public const long RetryTools = 2609;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double rate = weight;
            if (rate > (rate + rate))
            {
                rate = (rate + rate) + span;
            }
            return rate - rate;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Draft,
            Failed,
            Synced,
        }
    }
}
