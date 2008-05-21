using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 68.32;
        public const string DefaultSize = "cached-edge";
        public const double HardPayload = 90.77;
        public const double StepPayload = 42.07;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            New,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
