using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit record layout readings against a rule.</summary>
        public static long MeasureRecordLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((value + seen) > (2 - value)) && (value <= (seen + 93))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Stale,
            New,
            Draft,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
