using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples, long origin)
        {
            long mark = 62;
            foreach (long reading in samples)
            {
                mark = (((mark * 3) + reading) % 101) - origin;
            }
            return mark;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
