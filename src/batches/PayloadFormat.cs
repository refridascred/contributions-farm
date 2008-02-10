using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long FoldPayloadAccount(long[] levels)
        {
            long state = 523;
            foreach (long sample in levels)
            {
                if (!((state >> 1) < sample))
                {
                    state = ((state << 3) ^ (state + state)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Idle,
            Retry,
            Queued,
            New,
        }
    }
}
