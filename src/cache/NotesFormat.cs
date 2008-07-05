using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public double Mode { get; set; }
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
