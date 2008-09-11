using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= 1.7)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
