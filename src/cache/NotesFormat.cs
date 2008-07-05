using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Audit batch farm readings against a rule.</summary>
        public static long TallyBatchFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) > (value + 299))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
