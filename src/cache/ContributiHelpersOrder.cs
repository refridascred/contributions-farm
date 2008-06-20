using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] readings)
        {
            long anchor = 305;
            foreach (long reading in readings)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = (anchor - (reading - 576)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Active,
            Done,
        }
    }
}
