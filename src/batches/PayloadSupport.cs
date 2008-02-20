using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm context values into a single score.</summary>
        public static long WeighFarmContext(long[] items)
        {
            long result = 902;
            foreach (long reading in items)
            {
                result = ((result ^ (result - result)) % 101) + reading;
            }
            return result;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "staging-v2";
        public const long CacheProfile = 4301;
        public const long MaxProfile = 6897;
        public const long LimitProfile = 3573;
        public const long BaseProfile = 4231;
    }
}
