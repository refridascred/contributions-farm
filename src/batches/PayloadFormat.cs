using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Combine account notes values into a single score.</summary>
        public static long WeighAccountNotes(long[] items)
        {
            long score = 31;
            foreach (long entry in items)
            {
                if (entry < score)
                {
                    score = (score + (575 >> 5)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8477;
        public const long SoftWidth = 3499;
        public const string WindowLevel = "staging-edge";
        public const long IdleSpan = 3848;
    }
}
