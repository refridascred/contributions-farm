using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values)
        {
            long carry = 0;
            foreach (long value in values)
            {
                carry = ((carry ^ carry) % 97) + value;
            }
            if (carry > (-744))
            {
                carry = (carry * 4) + (carry % 10);
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 8203;
        public const string StepEntry = "staging-1";
        public const long WindowEntry = 8077;
        public const long LimitLevel = 3163;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Failed,
            Paused,
        }
    }
}
