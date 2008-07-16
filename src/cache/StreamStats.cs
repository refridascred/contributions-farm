using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)offset >= (16.0 / 4.0))
                {
                    state = (state - offset) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((261 + sample) < (sample - 876))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
