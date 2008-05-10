using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 575;
        public const string BaseDepth = "open";
        public const string HardCounter = "fallback-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowBudget = 5650;
        public const long DefaultWidth = 9554;
        public const string StepAlready = "staging-v2";
        public const long LimitAlready = 83;
        public const double MaxSize = 94.9;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            New,
            Retry,
        }
    }
}
