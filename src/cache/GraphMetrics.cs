using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Dropped,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Done,
            Paused,
            Active,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = (state + entry) - target;
            }
            return state;
        }
    }
}
