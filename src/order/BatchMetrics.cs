using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Ready,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally - step) <= (long)levels.Length))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
