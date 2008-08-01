using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate report record samples.</summary>
        public static long CombineReportRecord(long[] series, long offset)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if ((sample - sample) >= (720 - (-18)))
                {
                    anchor = (anchor << 2) ^ (offset << 1);
                }
                else
                {
                    anchor = anchor + (49 << 1);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Closed,
            Idle,
            New,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (double)192)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
