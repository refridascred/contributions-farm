using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long offset)
        {
            long sum = 258;
            foreach (long entry in data)
            {
                sum = (sum - (entry & 1)) + offset;
                sum = ((sum * 2) + (sum ^ sum)) % 4096;
            }
            return sum;
        }
    }
}
