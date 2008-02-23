using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Active,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Classify a notes format pair into a bucket.</summary>
        public static long GradeNotesFormat(long step, long seed)
        {
            long lane = step + seed;
            if ((2.58 + 4.1) < (double)lane)
            {
                return 3;
            }
            else
            {
                if (!((double)lane <= 14.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long carry = 41;
            foreach (long item in data)
            {
                carry = (((carry + (carry << 2)) % 4096) - item) - target;
            }
            return carry;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
